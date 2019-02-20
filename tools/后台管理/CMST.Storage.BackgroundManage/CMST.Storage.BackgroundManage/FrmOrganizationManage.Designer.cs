namespace CMST.Storage.BackgroundManage
{
    partial class FrmOrganizationManage
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
            this.gbOrganization = new System.Windows.Forms.GroupBox();
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.labcode = new System.Windows.Forms.Label();
            this.btnSaveCmst = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbIfUse = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.cmstID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmstSysAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstIfUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSysAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            this.gbinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrganization
            // 
            this.gbOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrganization.Controls.Add(this.dgvOrganization);
            this.gbOrganization.Location = new System.Drawing.Point(12, 3);
            this.gbOrganization.Name = "gbOrganization";
            this.gbOrganization.Size = new System.Drawing.Size(585, 441);
            this.gbOrganization.TabIndex = 1;
            this.gbOrganization.TabStop = false;
            this.gbOrganization.Text = "帐套信息";
            // 
            // dgvOrganization
            // 
            this.dgvOrganization.AllowUserToAddRows = false;
            this.dgvOrganization.AllowUserToDeleteRows = false;
            this.dgvOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganization.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrganization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmstID,
            this.cmstName,
            this.CmstSysAccount,
            this.cmstIfUse,
            this.cmstState});
            this.dgvOrganization.Location = new System.Drawing.Point(6, 20);
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.ReadOnly = true;
            this.dgvOrganization.RowHeadersVisible = false;
            this.dgvOrganization.RowTemplate.Height = 23;
            this.dgvOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganization.Size = new System.Drawing.Size(570, 415);
            this.dgvOrganization.TabIndex = 0;
            this.dgvOrganization.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrganization_CellMouseClick);
            // 
            // gbinfo
            // 
            this.gbinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbinfo.Controls.Add(this.cbIfUse);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Controls.Add(this.txtSysAccount);
            this.gbinfo.Controls.Add(this.label1);
            this.gbinfo.Controls.Add(this.btnQuery);
            this.gbinfo.Controls.Add(this.txtcode);
            this.gbinfo.Controls.Add(this.labcode);
            this.gbinfo.Controls.Add(this.btnSaveCmst);
            this.gbinfo.Controls.Add(this.btnAdd);
            this.gbinfo.Controls.Add(this.txtName);
            this.gbinfo.Controls.Add(this.labName);
            this.gbinfo.Location = new System.Drawing.Point(603, 3);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(210, 441);
            this.gbinfo.TabIndex = 2;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "帐套相关";
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Location = new System.Drawing.Point(68, 256);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 34);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(66, 33);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(137, 21);
            this.txtcode.TabIndex = 7;
            // 
            // labcode
            // 
            this.labcode.AutoSize = true;
            this.labcode.Location = new System.Drawing.Point(6, 36);
            this.labcode.Name = "labcode";
            this.labcode.Size = new System.Drawing.Size(65, 12);
            this.labcode.TabIndex = 6;
            this.labcode.Text = "帐套编号：";
            // 
            // btnSaveCmst
            // 
            this.btnSaveCmst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCmst.Location = new System.Drawing.Point(122, 324);
            this.btnSaveCmst.Name = "btnSaveCmst";
            this.btnSaveCmst.Size = new System.Drawing.Size(75, 34);
            this.btnSaveCmst.TabIndex = 5;
            this.btnSaveCmst.Text = "保存";
            this.btnSaveCmst.UseVisualStyleBackColor = true;
            this.btnSaveCmst.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(16, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbIfUse
            // 
            this.cbIfUse.AutoSize = true;
            this.cbIfUse.Location = new System.Drawing.Point(71, 176);
            this.cbIfUse.Name = "cbIfUse";
            this.cbIfUse.Size = new System.Drawing.Size(72, 16);
            this.cbIfUse.TabIndex = 3;
            this.cbIfUse.Text = "是否启用";
            this.cbIfUse.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 1;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(6, 82);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(65, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "帐套名称：";
            // 
            // cmstID
            // 
            this.cmstID.DataPropertyName = "CmstID";
            this.cmstID.HeaderText = "账套编号";
            this.cmstID.Name = "cmstID";
            this.cmstID.ReadOnly = true;
            // 
            // cmstName
            // 
            this.cmstName.DataPropertyName = "CmstName";
            this.cmstName.HeaderText = "账套名称";
            this.cmstName.Name = "cmstName";
            this.cmstName.ReadOnly = true;
            // 
            // CmstSysAccount
            // 
            this.CmstSysAccount.DataPropertyName = "CmstSysAccount";
            this.CmstSysAccount.HeaderText = "账套主管";
            this.CmstSysAccount.Name = "CmstSysAccount";
            this.CmstSysAccount.ReadOnly = true;
            // 
            // cmstIfUse
            // 
            this.cmstIfUse.DataPropertyName = "CmstIfUse";
            this.cmstIfUse.HeaderText = "状态码";
            this.cmstIfUse.Name = "cmstIfUse";
            this.cmstIfUse.ReadOnly = true;
            this.cmstIfUse.Visible = false;
            // 
            // cmstState
            // 
            this.cmstState.DataPropertyName = "CmstState";
            this.cmstState.HeaderText = "是否启用";
            this.cmstState.Name = "cmstState";
            this.cmstState.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "帐套主管：";
            // 
            // txtSysAccount
            // 
            this.txtSysAccount.Location = new System.Drawing.Point(66, 124);
            this.txtSysAccount.Name = "txtSysAccount";
            this.txtSysAccount.Size = new System.Drawing.Size(137, 21);
            this.txtSysAccount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "状    态：";
            // 
            // FrmOrganizationManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 456);
            this.Controls.Add(this.gbinfo);
            this.Controls.Add(this.gbOrganization);
            this.Name = "FrmOrganizationManage";
            this.Text = "帐套管理";
            this.gbOrganization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrganization;
        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.Button btnSaveCmst;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbIfUse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label labcode;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmstSysAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstIfUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSysAccount;
        private System.Windows.Forms.Label label1;
    }
}