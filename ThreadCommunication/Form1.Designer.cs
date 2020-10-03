namespace ThreadCommunication
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
            this.btnNewProducer = new System.Windows.Forms.Button();
            this.btnNewConsumer = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbConsume = new System.Windows.Forms.ListBox();
            this.cbCanConsume = new System.Windows.Forms.CheckBox();
            this.cbCanProduce = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewProducer
            // 
            this.btnNewProducer.Location = new System.Drawing.Point(13, 13);
            this.btnNewProducer.Name = "btnNewProducer";
            this.btnNewProducer.Size = new System.Drawing.Size(137, 40);
            this.btnNewProducer.TabIndex = 0;
            this.btnNewProducer.Text = "创建生产者";
            this.btnNewProducer.UseVisualStyleBackColor = true;
            this.btnNewProducer.Click += new System.EventHandler(this.btnNewProducer_Click);
            // 
            // btnNewConsumer
            // 
            this.btnNewConsumer.Location = new System.Drawing.Point(365, 13);
            this.btnNewConsumer.Name = "btnNewConsumer";
            this.btnNewConsumer.Size = new System.Drawing.Size(137, 40);
            this.btnNewConsumer.TabIndex = 2;
            this.btnNewConsumer.Text = "创建消费者";
            this.btnNewConsumer.UseVisualStyleBackColor = true;
            this.btnNewConsumer.Click += new System.EventHandler(this.btnNewConsumer_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 15;
            this.lbProducts.Location = new System.Drawing.Point(13, 60);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(324, 379);
            this.lbProducts.TabIndex = 3;
            // 
            // lbConsume
            // 
            this.lbConsume.FormattingEnabled = true;
            this.lbConsume.ItemHeight = 15;
            this.lbConsume.Location = new System.Drawing.Point(365, 60);
            this.lbConsume.Name = "lbConsume";
            this.lbConsume.Size = new System.Drawing.Size(335, 379);
            this.lbConsume.TabIndex = 4;
            // 
            // cbCanConsume
            // 
            this.cbCanConsume.AutoSize = true;
            this.cbCanConsume.Checked = true;
            this.cbCanConsume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCanConsume.Location = new System.Drawing.Point(509, 13);
            this.cbCanConsume.Name = "cbCanConsume";
            this.cbCanConsume.Size = new System.Drawing.Size(89, 19);
            this.cbCanConsume.TabIndex = 7;
            this.cbCanConsume.Text = "允许消费";
            this.cbCanConsume.UseVisualStyleBackColor = true;
            this.cbCanConsume.CheckedChanged += new System.EventHandler(this.cbCanConsume_CheckedChanged);
            // 
            // cbCanProduce
            // 
            this.cbCanProduce.AutoSize = true;
            this.cbCanProduce.Checked = true;
            this.cbCanProduce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCanProduce.Location = new System.Drawing.Point(157, 13);
            this.cbCanProduce.Name = "cbCanProduce";
            this.cbCanProduce.Size = new System.Drawing.Size(89, 19);
            this.cbCanProduce.TabIndex = 8;
            this.cbCanProduce.Text = "生产产品";
            this.cbCanProduce.UseVisualStyleBackColor = true;
            this.cbCanProduce.CheckedChanged += new System.EventHandler(this.cbCanProduce_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "每点一次“创建生产者/消费”便会多创建一个生产者/消费者。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCanProduce);
            this.Controls.Add(this.cbCanConsume);
            this.Controls.Add(this.lbConsume);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnNewConsumer);
            this.Controls.Add(this.btnNewProducer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "线程通信与同步";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProducer;
        private System.Windows.Forms.Button btnNewConsumer;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbConsume;
        private System.Windows.Forms.CheckBox cbCanConsume;
        private System.Windows.Forms.CheckBox cbCanProduce;
        private System.Windows.Forms.Label label1;
    }
}

