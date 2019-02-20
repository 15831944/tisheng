namespace CMST.Storage.BackgroundManage
{
    partial class FrmDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBIp = new System.Windows.Forms.TextBox();
            this.txtDBPort = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtDBSa = new System.Windows.Forms.TextBox();
            this.txtDBPwd = new System.Windows.Forms.TextBox();
            this.labDBStatus = new System.Windows.Forms.GroupBox();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.nidatabase = new System.Windows.Forms.NotifyIcon(this.components);
            this.pBoxdatabase = new System.Windows.Forms.PictureBox();
            this.imageListdblogo = new System.Windows.Forms.ImageList(this.components);
            this.labDBStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxdatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "账户：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
            // 
            // txtDBIp
            // 
            this.txtDBIp.Location = new System.Drawing.Point(93, 20);
            this.txtDBIp.Name = "txtDBIp";
            this.txtDBIp.Size = new System.Drawing.Size(121, 21);
            this.txtDBIp.TabIndex = 5;
            // 
            // txtDBPort
            // 
            this.txtDBPort.Location = new System.Drawing.Point(93, 59);
            this.txtDBPort.Name = "txtDBPort";
            this.txtDBPort.Size = new System.Drawing.Size(121, 21);
            this.txtDBPort.TabIndex = 6;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(93, 98);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(121, 21);
            this.txtDBName.TabIndex = 7;
            // 
            // txtDBSa
            // 
            this.txtDBSa.Location = new System.Drawing.Point(93, 137);
            this.txtDBSa.Name = "txtDBSa";
            this.txtDBSa.Size = new System.Drawing.Size(121, 21);
            this.txtDBSa.TabIndex = 8;
            // 
            // txtDBPwd
            // 
            this.txtDBPwd.Location = new System.Drawing.Point(93, 176);
            this.txtDBPwd.Name = "txtDBPwd";
            this.txtDBPwd.Size = new System.Drawing.Size(121, 21);
            this.txtDBPwd.TabIndex = 9;
            // 
            // labDBStatus
            // 
            this.labDBStatus.Controls.Add(this.pBoxdatabase);
            this.labDBStatus.Controls.Add(this.btnTestConnect);
            this.labDBStatus.Controls.Add(this.label1);
            this.labDBStatus.Controls.Add(this.label5);
            this.labDBStatus.Controls.Add(this.txtDBPwd);
            this.labDBStatus.Controls.Add(this.txtDBIp);
            this.labDBStatus.Controls.Add(this.txtDBSa);
            this.labDBStatus.Controls.Add(this.label4);
            this.labDBStatus.Controls.Add(this.txtDBPort);
            this.labDBStatus.Controls.Add(this.txtDBName);
            this.labDBStatus.Controls.Add(this.label2);
            this.labDBStatus.Controls.Add(this.label3);
            this.labDBStatus.Location = new System.Drawing.Point(12, 12);
            this.labDBStatus.Name = "labDBStatus";
            this.labDBStatus.Size = new System.Drawing.Size(260, 266);
            this.labDBStatus.TabIndex = 10;
            this.labDBStatus.TabStop = false;
            this.labDBStatus.Text = "状态：未连接";
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestConnect.Location = new System.Drawing.Point(93, 217);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(86, 33);
            this.btnTestConnect.TabIndex = 10;
            this.btnTestConnect.Text = "设置连接";
            this.btnTestConnect.UseVisualStyleBackColor = true;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // nidatabase
            // 
            this.nidatabase.Icon = ((System.Drawing.Icon)(resources.GetObject("nidatabase.Icon")));
            this.nidatabase.Text = "数据库设置";
            this.nidatabase.Visible = true;
            this.nidatabase.DoubleClick += new System.EventHandler(this.nidatabase_DoubleClick);
            // 
            // pBoxdatabase
            // 
            this.pBoxdatabase.Location = new System.Drawing.Point(30, 210);
            this.pBoxdatabase.Name = "pBoxdatabase";
            this.pBoxdatabase.Size = new System.Drawing.Size(51, 47);
            this.pBoxdatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxdatabase.TabIndex = 11;
            this.pBoxdatabase.TabStop = false;
            // 
            // imageListdblogo
            // 
            this.imageListdblogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListdblogo.ImageStream")));
            this.imageListdblogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListdblogo.Images.SetKeyName(0, "db1.ico");
            this.imageListdblogo.Images.SetKeyName(1, "db2.ico");
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.labDBStatus);
            this.Name = "FrmDatabase";
            this.Text = "数据库连接";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDatabase_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmDatabase_SizeChanged);
            this.labDBStatus.ResumeLayout(false);
            this.labDBStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxdatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBIp;
        private System.Windows.Forms.TextBox txtDBPort;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtDBSa;
        private System.Windows.Forms.TextBox txtDBPwd;
        private System.Windows.Forms.GroupBox labDBStatus;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.NotifyIcon nidatabase;
        private System.Windows.Forms.PictureBox pBoxdatabase;
        private System.Windows.Forms.ImageList imageListdblogo;
    }
}