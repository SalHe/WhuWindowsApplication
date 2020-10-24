namespace MergeMutipleTextFile
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.tbOutputFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lbTextFileName = new System.Windows.Forms.ListBox();
            this.btnRefreshFileList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "源目录：";
            // 
            // tbInputDirectory
            // 
            this.tbInputDirectory.Location = new System.Drawing.Point(86, 12);
            this.tbInputDirectory.Name = "tbInputDirectory";
            this.tbInputDirectory.ReadOnly = true;
            this.tbInputDirectory.Size = new System.Drawing.Size(379, 25);
            this.tbInputDirectory.TabIndex = 1;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(471, 15);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(46, 25);
            this.btnSelectDir.TabIndex = 2;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.Location = new System.Drawing.Point(471, 43);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(46, 25);
            this.btnSelectSavePath.TabIndex = 5;
            this.btnSelectSavePath.Text = "...";
            this.btnSelectSavePath.UseVisualStyleBackColor = true;
            this.btnSelectSavePath.Click += new System.EventHandler(this.btnSelectSavePath_Click);
            // 
            // tbOutputFilePath
            // 
            this.tbOutputFilePath.Location = new System.Drawing.Point(86, 43);
            this.tbOutputFilePath.Name = "tbOutputFilePath";
            this.tbOutputFilePath.ReadOnly = true;
            this.tbOutputFilePath.Size = new System.Drawing.Size(379, 25);
            this.tbOutputFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出文件：";
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(523, 43);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(72, 25);
            this.btnMerge.TabIndex = 6;
            this.btnMerge.Text = "合并";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lbTextFileName
            // 
            this.lbTextFileName.FormattingEnabled = true;
            this.lbTextFileName.ItemHeight = 15;
            this.lbTextFileName.Location = new System.Drawing.Point(12, 74);
            this.lbTextFileName.Name = "lbTextFileName";
            this.lbTextFileName.Size = new System.Drawing.Size(583, 259);
            this.lbTextFileName.TabIndex = 7;
            // 
            // btnRefreshFileList
            // 
            this.btnRefreshFileList.Location = new System.Drawing.Point(523, 15);
            this.btnRefreshFileList.Name = "btnRefreshFileList";
            this.btnRefreshFileList.Size = new System.Drawing.Size(72, 25);
            this.btnRefreshFileList.TabIndex = 8;
            this.btnRefreshFileList.Text = "刷新";
            this.btnRefreshFileList.UseVisualStyleBackColor = true;
            this.btnRefreshFileList.Click += new System.EventHandler(this.btnRefreshFileList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 348);
            this.Controls.Add(this.btnRefreshFileList);
            this.Controls.Add(this.lbTextFileName);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSelectSavePath);
            this.Controls.Add(this.tbOutputFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.tbInputDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合并多个文本文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputDirectory;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.Button btnSelectSavePath;
        private System.Windows.Forms.TextBox tbOutputFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.ListBox lbTextFileName;
        private System.Windows.Forms.Button btnRefreshFileList;
    }
}

