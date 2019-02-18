namespace Runservice
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
            this.IP_txt = new System.Windows.Forms.TextBox();
            this.Port_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RunService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP_txt
            // 
            this.IP_txt.Location = new System.Drawing.Point(99, 51);
            this.IP_txt.Margin = new System.Windows.Forms.Padding(2);
            this.IP_txt.Name = "IP_txt";
            this.IP_txt.Size = new System.Drawing.Size(135, 21);
            this.IP_txt.TabIndex = 0;
            this.IP_txt.Text = "127.0.0.1";
            // 
            // Port_txt
            // 
            this.Port_txt.Location = new System.Drawing.Point(99, 92);
            this.Port_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.Size = new System.Drawing.Size(136, 21);
            this.Port_txt.TabIndex = 1;
            this.Port_txt.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号:";
            // 
            // RunService
            // 
            this.RunService.Location = new System.Drawing.Point(27, 151);
            this.RunService.Name = "RunService";
            this.RunService.Size = new System.Drawing.Size(114, 23);
            this.RunService.TabIndex = 4;
            this.RunService.Text = "启动服务";
            this.RunService.UseVisualStyleBackColor = true;
            this.RunService.Click += new System.EventHandler(this.RunService_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.RunService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port_txt);
            this.Controls.Add(this.IP_txt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_txt;
        private System.Windows.Forms.TextBox Port_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunService;
    }
}

