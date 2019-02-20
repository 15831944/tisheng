namespace CMST.Storage.BackgroundManage
{
    partial class FrmAuthorityManage
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
            this.tabAuthorityManage = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.tabOperate = new System.Windows.Forms.TabPage();
            this.tvOperate = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMenuInfo = new System.Windows.Forms.GroupBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtFatherMenu = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnAddFather = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.gbOperate = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOperateName = new System.Windows.Forms.TextBox();
            this.txtOperateUrl = new System.Windows.Forms.TextBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.btnAddOperate = new System.Windows.Forms.Button();
            this.btnSaveOperate = new System.Windows.Forms.Button();
            this.tabAuthorityManage.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabOperate.SuspendLayout();
            this.gbMenuInfo.SuspendLayout();
            this.gbOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAuthorityManage
            // 
            this.tabAuthorityManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAuthorityManage.Controls.Add(this.tabMenu);
            this.tabAuthorityManage.Controls.Add(this.tabOperate);
            this.tabAuthorityManage.Location = new System.Drawing.Point(5, 3);
            this.tabAuthorityManage.Name = "tabAuthorityManage";
            this.tabAuthorityManage.SelectedIndex = 0;
            this.tabAuthorityManage.Size = new System.Drawing.Size(566, 352);
            this.tabAuthorityManage.TabIndex = 0;
            this.tabAuthorityManage.SelectedIndexChanged += new System.EventHandler(this.tabAuthorityManage_SelectedIndexChanged);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.gbMenuInfo);
            this.tabMenu.Controls.Add(this.tvMenu);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(558, 326);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "菜单维护";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // tvMenu
            // 
            this.tvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMenu.Location = new System.Drawing.Point(6, 6);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(286, 317);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // tabOperate
            // 
            this.tabOperate.Controls.Add(this.gbOperate);
            this.tabOperate.Controls.Add(this.tvOperate);
            this.tabOperate.Location = new System.Drawing.Point(4, 22);
            this.tabOperate.Name = "tabOperate";
            this.tabOperate.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperate.Size = new System.Drawing.Size(558, 326);
            this.tabOperate.TabIndex = 1;
            this.tabOperate.Text = "操作维护";
            this.tabOperate.UseVisualStyleBackColor = true;
            // 
            // tvOperate
            // 
            this.tvOperate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvOperate.Location = new System.Drawing.Point(6, 6);
            this.tvOperate.Name = "tvOperate";
            this.tvOperate.Size = new System.Drawing.Size(286, 317);
            this.tvOperate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "菜单名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "上级菜单：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "菜单等级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL：";
            // 
            // gbMenuInfo
            // 
            this.gbMenuInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMenuInfo.Controls.Add(this.btnAddSub);
            this.gbMenuInfo.Controls.Add(this.btnSave);
            this.gbMenuInfo.Controls.Add(this.btnAddFather);
            this.gbMenuInfo.Controls.Add(this.txtUrl);
            this.gbMenuInfo.Controls.Add(this.txtRank);
            this.gbMenuInfo.Controls.Add(this.txtFatherMenu);
            this.gbMenuInfo.Controls.Add(this.txtMenuName);
            this.gbMenuInfo.Controls.Add(this.label1);
            this.gbMenuInfo.Controls.Add(this.label4);
            this.gbMenuInfo.Controls.Add(this.label3);
            this.gbMenuInfo.Controls.Add(this.label2);
            this.gbMenuInfo.Location = new System.Drawing.Point(298, 0);
            this.gbMenuInfo.Name = "gbMenuInfo";
            this.gbMenuInfo.Size = new System.Drawing.Size(254, 320);
            this.gbMenuInfo.TabIndex = 5;
            this.gbMenuInfo.TabStop = false;
            this.gbMenuInfo.Text = "菜单信息";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(88, 46);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(118, 21);
            this.txtMenuName.TabIndex = 5;
            // 
            // txtFatherMenu
            // 
            this.txtFatherMenu.Location = new System.Drawing.Point(88, 103);
            this.txtFatherMenu.Name = "txtFatherMenu";
            this.txtFatherMenu.ReadOnly = true;
            this.txtFatherMenu.Size = new System.Drawing.Size(118, 21);
            this.txtFatherMenu.TabIndex = 6;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(88, 160);
            this.txtRank.Name = "txtRank";
            this.txtRank.ReadOnly = true;
            this.txtRank.Size = new System.Drawing.Size(118, 21);
            this.txtRank.TabIndex = 7;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(88, 217);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(118, 21);
            this.txtUrl.TabIndex = 8;
            // 
            // btnAddFather
            // 
            this.btnAddFather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFather.Location = new System.Drawing.Point(41, 260);
            this.btnAddFather.Name = "btnAddFather";
            this.btnAddFather.Size = new System.Drawing.Size(75, 23);
            this.btnAddFather.TabIndex = 9;
            this.btnAddFather.Text = "添加同级";
            this.btnAddFather.UseVisualStyleBackColor = true;
            this.btnAddFather.Click += new System.EventHandler(this.btnAddFather_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(88, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSub.Location = new System.Drawing.Point(131, 260);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(75, 23);
            this.btnAddSub.TabIndex = 11;
            this.btnAddSub.Text = "添加下级";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // gbOperate
            // 
            this.gbOperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOperate.Controls.Add(this.btnSaveOperate);
            this.gbOperate.Controls.Add(this.btnAddOperate);
            this.gbOperate.Controls.Add(this.txtMenu);
            this.gbOperate.Controls.Add(this.txtOperateUrl);
            this.gbOperate.Controls.Add(this.txtOperateName);
            this.gbOperate.Controls.Add(this.label7);
            this.gbOperate.Controls.Add(this.label6);
            this.gbOperate.Controls.Add(this.label5);
            this.gbOperate.Location = new System.Drawing.Point(299, 0);
            this.gbOperate.Name = "gbOperate";
            this.gbOperate.Size = new System.Drawing.Size(253, 323);
            this.gbOperate.TabIndex = 1;
            this.gbOperate.TabStop = false;
            this.gbOperate.Text = "操作信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "操作名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "菜单：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Url：";
            // 
            // txtOperateName
            // 
            this.txtOperateName.Location = new System.Drawing.Point(84, 34);
            this.txtOperateName.Name = "txtOperateName";
            this.txtOperateName.Size = new System.Drawing.Size(132, 21);
            this.txtOperateName.TabIndex = 3;
            // 
            // txtOperateUrl
            // 
            this.txtOperateUrl.Location = new System.Drawing.Point(84, 134);
            this.txtOperateUrl.Name = "txtOperateUrl";
            this.txtOperateUrl.Size = new System.Drawing.Size(132, 21);
            this.txtOperateUrl.TabIndex = 4;
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(84, 87);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.ReadOnly = true;
            this.txtMenu.Size = new System.Drawing.Size(132, 21);
            this.txtMenu.TabIndex = 5;
            // 
            // btnAddOperate
            // 
            this.btnAddOperate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOperate.Location = new System.Drawing.Point(84, 207);
            this.btnAddOperate.Name = "btnAddOperate";
            this.btnAddOperate.Size = new System.Drawing.Size(87, 28);
            this.btnAddOperate.TabIndex = 6;
            this.btnAddOperate.Text = "添加";
            this.btnAddOperate.UseVisualStyleBackColor = true;
            this.btnAddOperate.Click += new System.EventHandler(this.btnAddOperate_Click);
            // 
            // btnSaveOperate
            // 
            this.btnSaveOperate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveOperate.Location = new System.Drawing.Point(84, 263);
            this.btnSaveOperate.Name = "btnSaveOperate";
            this.btnSaveOperate.Size = new System.Drawing.Size(87, 28);
            this.btnSaveOperate.TabIndex = 7;
            this.btnSaveOperate.Text = "保存";
            this.btnSaveOperate.UseVisualStyleBackColor = true;
            this.btnSaveOperate.Click += new System.EventHandler(this.btnSaveOperate_Click);
            // 
            // FrmAuthorityManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 356);
            this.Controls.Add(this.tabAuthorityManage);
            this.Name = "FrmAuthorityManage";
            this.Text = "权限管理";
            this.tabAuthorityManage.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabOperate.ResumeLayout(false);
            this.gbMenuInfo.ResumeLayout(false);
            this.gbMenuInfo.PerformLayout();
            this.gbOperate.ResumeLayout(false);
            this.gbOperate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAuthorityManage;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabOperate;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.TreeView tvOperate;
        private System.Windows.Forms.GroupBox gbMenuInfo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtFatherMenu;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddFather;
        private System.Windows.Forms.GroupBox gbOperate;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.TextBox txtOperateUrl;
        private System.Windows.Forms.TextBox txtOperateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveOperate;
        private System.Windows.Forms.Button btnAddOperate;
    }
}