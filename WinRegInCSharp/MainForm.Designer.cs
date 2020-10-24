namespace WinRegInCSharp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateSubKey = new System.Windows.Forms.Button();
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKeyPath = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTestString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTestDword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWrite2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.btnCreateSubKey2 = new System.Windows.Forms.Button();
            this.btnCrateKey2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnCreateSubKey);
            this.groupBox1.Controls.Add(this.btnCreateKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".NET API";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(269, 24);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 34);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(188, 25);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 34);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreateSubKey
            // 
            this.btnCreateSubKey.Location = new System.Drawing.Point(88, 24);
            this.btnCreateSubKey.Name = "btnCreateSubKey";
            this.btnCreateSubKey.Size = new System.Drawing.Size(94, 34);
            this.btnCreateSubKey.TabIndex = 1;
            this.btnCreateSubKey.Text = "创建子KEY";
            this.btnCreateSubKey.UseVisualStyleBackColor = true;
            this.btnCreateSubKey.Click += new System.EventHandler(this.btnCreateSubKey_Click);
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Location = new System.Drawing.Point(7, 25);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(75, 34);
            this.btnCreateKey.TabIndex = 0;
            this.btnCreateKey.Text = "创建KEY";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "HKEY_CURRENT_USER\\";
            // 
            // labelKeyPath
            // 
            this.labelKeyPath.AutoSize = true;
            this.labelKeyPath.Location = new System.Drawing.Point(161, 12);
            this.labelKeyPath.Name = "labelKeyPath";
            this.labelKeyPath.Size = new System.Drawing.Size(39, 15);
            this.labelKeyPath.TabIndex = 2;
            this.labelKeyPath.Text = "PATH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTestString);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTestDword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Value";
            // 
            // tbTestString
            // 
            this.tbTestString.Location = new System.Drawing.Point(99, 57);
            this.tbTestString.Name = "tbTestString";
            this.tbTestString.Size = new System.Drawing.Size(346, 25);
            this.tbTestString.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TestString: ";
            // 
            // tbTestDword
            // 
            this.tbTestDword.Location = new System.Drawing.Point(99, 25);
            this.tbTestDword.Name = "tbTestDword";
            this.tbTestDword.Size = new System.Drawing.Size(346, 25);
            this.tbTestDword.TabIndex = 1;
            this.tbTestDword.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "TestDword: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWrite2);
            this.groupBox3.Controls.Add(this.btnRead2);
            this.groupBox3.Controls.Add(this.btnCreateSubKey2);
            this.groupBox3.Controls.Add(this.btnCrateKey2);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 69);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Win32 API";
            // 
            // btnWrite2
            // 
            this.btnWrite2.Location = new System.Drawing.Point(269, 24);
            this.btnWrite2.Name = "btnWrite2";
            this.btnWrite2.Size = new System.Drawing.Size(75, 34);
            this.btnWrite2.TabIndex = 3;
            this.btnWrite2.Text = "写入";
            this.btnWrite2.UseVisualStyleBackColor = true;
            this.btnWrite2.Click += new System.EventHandler(this.btnWrite2_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Location = new System.Drawing.Point(188, 25);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(75, 34);
            this.btnRead2.TabIndex = 2;
            this.btnRead2.Text = "读取";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // btnCreateSubKey2
            // 
            this.btnCreateSubKey2.Location = new System.Drawing.Point(88, 24);
            this.btnCreateSubKey2.Name = "btnCreateSubKey2";
            this.btnCreateSubKey2.Size = new System.Drawing.Size(94, 34);
            this.btnCreateSubKey2.TabIndex = 1;
            this.btnCreateSubKey2.Text = "创建子KEY";
            this.btnCreateSubKey2.UseVisualStyleBackColor = true;
            this.btnCreateSubKey2.Click += new System.EventHandler(this.btnCreateSubKey2_Click);
            // 
            // btnCrateKey2
            // 
            this.btnCrateKey2.Location = new System.Drawing.Point(7, 25);
            this.btnCrateKey2.Name = "btnCrateKey2";
            this.btnCrateKey2.Size = new System.Drawing.Size(75, 34);
            this.btnCrateKey2.TabIndex = 0;
            this.btnCrateKey2.Text = "创建KEY";
            this.btnCrateKey2.UseVisualStyleBackColor = true;
            this.btnCrateKey2.Click += new System.EventHandler(this.btnCrateKey2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 295);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelKeyPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册表操作";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateSubKey;
        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKeyPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTestString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTestDword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWrite2;
        private System.Windows.Forms.Button btnRead2;
        private System.Windows.Forms.Button btnCreateSubKey2;
        private System.Windows.Forms.Button btnCrateKey2;
    }
}

