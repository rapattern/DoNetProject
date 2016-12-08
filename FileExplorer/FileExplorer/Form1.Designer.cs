namespace FileExplorer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.BtnSelectFolder = new System.Windows.Forms.Button();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.LstFileForProcess = new System.Windows.Forms.ListBox();
            this.BtnSearchProcess = new System.Windows.Forms.Button();
            this.BtnDeleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹：";
            // 
            // TxtFolderPath
            // 
            this.TxtFolderPath.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtFolderPath.Location = new System.Drawing.Point(84, 28);
            this.TxtFolderPath.Name = "TxtFolderPath";
            this.TxtFolderPath.Size = new System.Drawing.Size(251, 29);
            this.TxtFolderPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "文 件：";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtFilePath.Location = new System.Drawing.Point(84, 81);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(251, 29);
            this.TxtFilePath.TabIndex = 1;
            // 
            // BtnSelectFolder
            // 
            this.BtnSelectFolder.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSelectFolder.Location = new System.Drawing.Point(365, 25);
            this.BtnSelectFolder.Name = "BtnSelectFolder";
            this.BtnSelectFolder.Size = new System.Drawing.Size(91, 37);
            this.BtnSelectFolder.TabIndex = 2;
            this.BtnSelectFolder.Text = "选择";
            this.BtnSelectFolder.UseVisualStyleBackColor = true;
            this.BtnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSelectFile.Location = new System.Drawing.Point(365, 79);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(91, 35);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "选择";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // LstFileForProcess
            // 
            this.LstFileForProcess.FormattingEnabled = true;
            this.LstFileForProcess.ItemHeight = 12;
            this.LstFileForProcess.Location = new System.Drawing.Point(16, 186);
            this.LstFileForProcess.Name = "LstFileForProcess";
            this.LstFileForProcess.Size = new System.Drawing.Size(456, 232);
            this.LstFileForProcess.TabIndex = 3;
            // 
            // BtnSearchProcess
            // 
            this.BtnSearchProcess.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearchProcess.Location = new System.Drawing.Point(16, 132);
            this.BtnSearchProcess.Name = "BtnSearchProcess";
            this.BtnSearchProcess.Size = new System.Drawing.Size(91, 37);
            this.BtnSearchProcess.TabIndex = 2;
            this.BtnSearchProcess.Text = "检索";
            this.BtnSearchProcess.UseVisualStyleBackColor = true;
            this.BtnSearchProcess.Click += new System.EventHandler(this.BtnSearchProcess_Click);
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDeleteFile.Location = new System.Drawing.Point(365, 132);
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.Size = new System.Drawing.Size(91, 37);
            this.BtnDeleteFile.TabIndex = 2;
            this.BtnDeleteFile.Text = "删除";
            this.BtnDeleteFile.UseVisualStyleBackColor = true;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 434);
            this.Controls.Add(this.LstFileForProcess);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.BtnDeleteFile);
            this.Controls.Add(this.BtnSearchProcess);
            this.Controls.Add(this.BtnSelectFolder);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.TxtFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Button BtnSelectFolder;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.ListBox LstFileForProcess;
        private System.Windows.Forms.Button BtnSearchProcess;
        private System.Windows.Forms.Button BtnDeleteFile;
    }
}

