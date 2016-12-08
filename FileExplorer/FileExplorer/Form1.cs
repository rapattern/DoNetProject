using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private List<FileProcess> fileProcessList = new List<FileProcess>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtFolderPath.Text = dialog.SelectedPath;
            }
            else
            {
                TxtFolderPath.Text = string.Empty;
            }
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtFilePath.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// 搜索占用文件的进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchProcess_Click(object sender, EventArgs e)
        {
            List<string> fileList = new List<string>();
            if (!string.IsNullOrEmpty(TxtFolderPath.Text) && Directory.Exists(TxtFolderPath.Text))
            {
                GetAllFiles(fileList, TxtFolderPath.Text);
            }
            if (!string.IsNullOrEmpty(TxtFilePath.Text) && File.Exists(TxtFilePath.Text))
            {
                fileList.Add(TxtFilePath.Text);
            }

            foreach (var item in fileList)
            {
                Process tool = new Process();
                tool.StartInfo.FileName = Environment.CurrentDirectory + "/Handle/handle.exe";
                tool.StartInfo.Arguments = item + "/accepteula";
                tool.StartInfo.UseShellExecute = false;
                tool.StartInfo.RedirectStandardOutput = true;
                tool.Start();
                tool.WaitForExit();
                string outputTool = tool.StandardOutput.ReadToEnd();
                string matchPattern = @"(?<=\s+pid:\s+)\b(\d+)\b(?=\s+)";
                foreach (Match match in Regex.Matches(outputTool, matchPattern))
                {
                    Process p = Process.GetProcessById(int.Parse(match.Value));
                    FileProcess fp = new FileProcess(item)
                    {
                        ProcessId = p.Id,
                        ProcessName = p.ProcessName
                    };
                    p.Close();
                    fileProcessList.Add(fp);
                    LstFileForProcess.Items.Add(fp);
                    Application.DoEvents();
                }
                tool.Close();
            }
        }

        /// <summary>
        /// 删除占用文件的进程并删除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteFile_Click(object sender, EventArgs e)
        {
            if (LstFileForProcess.SelectedIndex < 0)
            {
                MessageBox.Show("请选择要删除的文件");
                return;
            }
            FileProcess selectFile = LstFileForProcess.SelectedItem as FileProcess;
            Process p = Process.GetProcessById(selectFile.ProcessId);
            if (p != null)
            {
                p.Kill();
            }
            File.Delete(selectFile.FilePath);
        }

        /// <summary>
        /// 获得文件夹下的所有文件包括子文件
        /// </summary>
        /// <param name="list"></param>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        private void GetAllFiles(List<string> list, string folderPath)
        {
            foreach (var item in Directory.GetDirectories(folderPath))
            {
                if (File.Exists(item))
                {
                    list.Add(item);
                }
                else
                {
                    GetAllFiles(list,item);
                }
            }
        }
    }

    public class FileProcess
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string FilePath { get; set; }
        public FileProcess(string filePath)
        {
            this.FilePath = filePath;
        }
        public string ToString()
        {
            return string.Format("进程Id:{0}-进程名:{1}-文件:{2}", ProcessId, ProcessName, FilePath);
        }
    }
}
