namespace ProcessCommunication
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCmdShutdown = new System.Windows.Forms.Button();
            this.tbCmd = new System.Windows.Forms.TextBox();
            this.btnCmdGetmac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPipeClientSend = new System.Windows.Forms.Button();
            this.tbPipeClientSend = new System.Windows.Forms.TextBox();
            this.tbPipeClient = new System.Windows.Forms.TextBox();
            this.btnPipeClientConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPipeServerSend = new System.Windows.Forms.Button();
            this.tbPipeServerSend = new System.Windows.Forms.TextBox();
            this.tbPipeServer = new System.Windows.Forms.TextBox();
            this.btnPipeServerOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCmdShutdown);
            this.groupBox1.Controls.Add(this.tbCmd);
            this.groupBox1.Controls.Add(this.btnCmdGetmac);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "重定向通信";
            // 
            // btnCmdShutdown
            // 
            this.btnCmdShutdown.Location = new System.Drawing.Point(166, 24);
            this.btnCmdShutdown.Name = "btnCmdShutdown";
            this.btnCmdShutdown.Size = new System.Drawing.Size(193, 28);
            this.btnCmdShutdown.TabIndex = 2;
            this.btnCmdShutdown.Text = "调用shutdown关机";
            this.btnCmdShutdown.UseVisualStyleBackColor = true;
            this.btnCmdShutdown.Click += new System.EventHandler(this.btnCmdShutdown_Click);
            // 
            // tbCmd
            // 
            this.tbCmd.Location = new System.Drawing.Point(7, 59);
            this.tbCmd.Multiline = true;
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.Size = new System.Drawing.Size(862, 168);
            this.tbCmd.TabIndex = 1;
            // 
            // btnCmdGetmac
            // 
            this.btnCmdGetmac.Location = new System.Drawing.Point(6, 24);
            this.btnCmdGetmac.Name = "btnCmdGetmac";
            this.btnCmdGetmac.Size = new System.Drawing.Size(153, 28);
            this.btnCmdGetmac.TabIndex = 0;
            this.btnCmdGetmac.Text = "获取网卡MAC";
            this.btnCmdGetmac.UseVisualStyleBackColor = true;
            this.btnCmdGetmac.Click += new System.EventHandler(this.btnCmdGetmac_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPipeClientSend);
            this.groupBox2.Controls.Add(this.tbPipeClientSend);
            this.groupBox2.Controls.Add(this.tbPipeClient);
            this.groupBox2.Controls.Add(this.btnPipeClientConnect);
            this.groupBox2.Location = new System.Drawing.Point(13, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管道通信 - 客户端";
            // 
            // btnPipeClientSend
            // 
            this.btnPipeClientSend.Location = new System.Drawing.Point(366, 324);
            this.btnPipeClientSend.Name = "btnPipeClientSend";
            this.btnPipeClientSend.Size = new System.Drawing.Size(59, 25);
            this.btnPipeClientSend.TabIndex = 4;
            this.btnPipeClientSend.Text = "发";
            this.btnPipeClientSend.UseVisualStyleBackColor = true;
            this.btnPipeClientSend.Click += new System.EventHandler(this.btnPipeClientSend_Click);
            // 
            // tbPipeClientSend
            // 
            this.tbPipeClientSend.Location = new System.Drawing.Point(6, 324);
            this.tbPipeClientSend.Name = "tbPipeClientSend";
            this.tbPipeClientSend.Size = new System.Drawing.Size(353, 25);
            this.tbPipeClientSend.TabIndex = 3;
            // 
            // tbPipeClient
            // 
            this.tbPipeClient.Location = new System.Drawing.Point(6, 63);
            this.tbPipeClient.Multiline = true;
            this.tbPipeClient.Name = "tbPipeClient";
            this.tbPipeClient.ReadOnly = true;
            this.tbPipeClient.Size = new System.Drawing.Size(419, 254);
            this.tbPipeClient.TabIndex = 2;
            // 
            // btnPipeClientConnect
            // 
            this.btnPipeClientConnect.Location = new System.Drawing.Point(7, 25);
            this.btnPipeClientConnect.Name = "btnPipeClientConnect";
            this.btnPipeClientConnect.Size = new System.Drawing.Size(92, 32);
            this.btnPipeClientConnect.TabIndex = 0;
            this.btnPipeClientConnect.Text = "连接";
            this.btnPipeClientConnect.UseVisualStyleBackColor = true;
            this.btnPipeClientConnect.Click += new System.EventHandler(this.btnPipeClientConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPipeServerSend);
            this.groupBox3.Controls.Add(this.tbPipeServerSend);
            this.groupBox3.Controls.Add(this.tbPipeServer);
            this.groupBox3.Controls.Add(this.btnPipeServerOpen);
            this.groupBox3.Location = new System.Drawing.Point(450, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "管道通信 - 服务器";
            // 
            // btnPipeServerSend
            // 
            this.btnPipeServerSend.Location = new System.Drawing.Point(366, 324);
            this.btnPipeServerSend.Name = "btnPipeServerSend";
            this.btnPipeServerSend.Size = new System.Drawing.Size(59, 25);
            this.btnPipeServerSend.TabIndex = 6;
            this.btnPipeServerSend.Text = "发";
            this.btnPipeServerSend.UseVisualStyleBackColor = true;
            this.btnPipeServerSend.Click += new System.EventHandler(this.btnPipeServerSend_Click);
            // 
            // tbPipeServerSend
            // 
            this.tbPipeServerSend.Location = new System.Drawing.Point(6, 324);
            this.tbPipeServerSend.Name = "tbPipeServerSend";
            this.tbPipeServerSend.Size = new System.Drawing.Size(353, 25);
            this.tbPipeServerSend.TabIndex = 5;
            // 
            // tbPipeServer
            // 
            this.tbPipeServer.Location = new System.Drawing.Point(7, 63);
            this.tbPipeServer.Multiline = true;
            this.tbPipeServer.Name = "tbPipeServer";
            this.tbPipeServer.ReadOnly = true;
            this.tbPipeServer.Size = new System.Drawing.Size(419, 254);
            this.tbPipeServer.TabIndex = 3;
            // 
            // btnPipeServerOpen
            // 
            this.btnPipeServerOpen.Location = new System.Drawing.Point(7, 25);
            this.btnPipeServerOpen.Name = "btnPipeServerOpen";
            this.btnPipeServerOpen.Size = new System.Drawing.Size(92, 32);
            this.btnPipeServerOpen.TabIndex = 0;
            this.btnPipeServerOpen.Text = "开启";
            this.btnPipeServerOpen.UseVisualStyleBackColor = true;
            this.btnPipeServerOpen.Click += new System.EventHandler(this.btnPipeServerOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进程通信";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCmdGetmac;
        private System.Windows.Forms.TextBox tbCmd;
        private System.Windows.Forms.Button btnCmdShutdown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPipeServerOpen;
        private System.Windows.Forms.Button btnPipeClientConnect;
        private System.Windows.Forms.TextBox tbPipeClient;
        private System.Windows.Forms.TextBox tbPipeServer;
        private System.Windows.Forms.TextBox tbPipeClientSend;
        private System.Windows.Forms.Button btnPipeClientSend;
        private System.Windows.Forms.Button btnPipeServerSend;
        private System.Windows.Forms.TextBox tbPipeServerSend;
    }
}

