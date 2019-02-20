namespace CMST.Storage.BackgroundManage
{
    partial class FrmBackgroundManage
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
            this._btnOrganization = new System.Windows.Forms.Button();
            this._btnAuthority = new System.Windows.Forms.Button();
            this._btnDatabase = new System.Windows.Forms.Button();
            this._btnBaseMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnOrganization
            // 
            this._btnOrganization.BackColor = System.Drawing.Color.Transparent;
            this._btnOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnOrganization.Location = new System.Drawing.Point(221, 301);
            this._btnOrganization.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this._btnOrganization.Name = "_btnOrganization";
            this._btnOrganization.Size = new System.Drawing.Size(167, 167);
            this._btnOrganization.TabIndex = 0;
            this._btnOrganization.Text = "帐套管理";
            this._btnOrganization.UseVisualStyleBackColor = false;
            // 
            // _btnAuthority
            // 
            this._btnAuthority.BackColor = System.Drawing.Color.Transparent;
            this._btnAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAuthority.Location = new System.Drawing.Point(460, 301);
            this._btnAuthority.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this._btnAuthority.Name = "_btnAuthority";
            this._btnAuthority.Size = new System.Drawing.Size(167, 167);
            this._btnAuthority.TabIndex = 1;
            this._btnAuthority.Text = "权限管理";
            this._btnAuthority.UseVisualStyleBackColor = false;
            // 
            // _btnDatabase
            // 
            this._btnDatabase.BackColor = System.Drawing.Color.Transparent;
            this._btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnDatabase.Location = new System.Drawing.Point(938, 301);
            this._btnDatabase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this._btnDatabase.Name = "_btnDatabase";
            this._btnDatabase.Size = new System.Drawing.Size(167, 167);
            this._btnDatabase.TabIndex = 2;
            this._btnDatabase.Text = "数据库设置";
            this._btnDatabase.UseVisualStyleBackColor = false;
            // 
            // _btnBaseMessage
            // 
            this._btnBaseMessage.BackColor = System.Drawing.Color.Transparent;
            this._btnBaseMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnBaseMessage.Location = new System.Drawing.Point(699, 301);
            this._btnBaseMessage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this._btnBaseMessage.Name = "_btnBaseMessage";
            this._btnBaseMessage.Size = new System.Drawing.Size(167, 167);
            this._btnBaseMessage.TabIndex = 3;
            this._btnBaseMessage.Text = "基础信息管理";
            this._btnBaseMessage.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(419, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "中 储 塑 化 软 件 后 台 管 理 系 统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CMST.Storage.BackgroundManage.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(315, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBackgroundManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMST.Storage.BackgroundManage.Properties.Resources._1366768bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1411, 760);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnBaseMessage);
            this.Controls.Add(this._btnDatabase);
            this.Controls.Add(this._btnAuthority);
            this.Controls.Add(this._btnOrganization);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmBackgroundManage";
            this.Text = "塑化软件后台管理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnOrganization;
        private System.Windows.Forms.Button _btnAuthority;
        private System.Windows.Forms.Button _btnDatabase;
        private System.Windows.Forms.Button _btnBaseMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

