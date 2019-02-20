namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new System.Windows.Forms.Button();
            this.cbComBoxEx3 = new CMST.Controls.CbComBoxEx();
            this.cbComBoxEx2 = new CMST.Controls.CbComBoxEx();
            this.dtpEx = new CMST.Controls.DateTimePickerEx();
            this.cbComBoxEx1 = new CMST.Controls.CbComBoxEx();
            this.comboBoxTreeView1 = new CMST.Controls.ComboBoxTreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbComBoxEx4 = new CMST.Controls.CbComBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(443, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(733, 268);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(23, 22);
            this.btnDetail.TabIndex = 14;
            this.btnDetail.Text = "button4";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // cbComBoxEx3
            // 
            this.cbComBoxEx3.FormattingEnabled = true;
            this.cbComBoxEx3.Location = new System.Drawing.Point(171, 251);
            this.cbComBoxEx3.Name = "cbComBoxEx3";
            this.cbComBoxEx3.Size = new System.Drawing.Size(121, 20);
            this.cbComBoxEx3.TabIndex = 11;
            // 
            // cbComBoxEx2
            // 
            this.cbComBoxEx2.FormattingEnabled = true;
            this.cbComBoxEx2.Location = new System.Drawing.Point(171, 197);
            this.cbComBoxEx2.Name = "cbComBoxEx2";
            this.cbComBoxEx2.Size = new System.Drawing.Size(121, 20);
            this.cbComBoxEx2.TabIndex = 10;
            // 
            // dtpEx
            // 
            this.dtpEx.Location = new System.Drawing.Point(139, 66);
            this.dtpEx.Name = "dtpEx";
            this.dtpEx.Size = new System.Drawing.Size(225, 26);
            this.dtpEx.TabIndex = 0;
            // 
            // cbComBoxEx1
            // 
            this.cbComBoxEx1.FormattingEnabled = true;
            this.cbComBoxEx1.Location = new System.Drawing.Point(171, 151);
            this.cbComBoxEx1.Name = "cbComBoxEx1";
            this.cbComBoxEx1.Size = new System.Drawing.Size(121, 20);
            this.cbComBoxEx1.TabIndex = 9;
            // 
            // comboBoxTreeView1
            // 
            this.comboBoxTreeView1.FormattingEnabled = true;
            this.comboBoxTreeView1.Location = new System.Drawing.Point(171, 381);
            this.comboBoxTreeView1.Name = "comboBoxTreeView1";
            this.comboBoxTreeView1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTreeView1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 16;
            // 
            // cbComBoxEx4
            // 
            this.cbComBoxEx4.FormattingEnabled = true;
            this.cbComBoxEx4.Location = new System.Drawing.Point(429, 49);
            this.cbComBoxEx4.Name = "cbComBoxEx4";
            this.cbComBoxEx4.Size = new System.Drawing.Size(121, 20);
            this.cbComBoxEx4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 549);
            this.Controls.Add(this.cbComBoxEx4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxTreeView1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbComBoxEx3);
            this.Controls.Add(this.cbComBoxEx2);
            this.Controls.Add(this.dtpEx);
            this.Controls.Add(this.cbComBoxEx1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CMST.Controls.DateTimePickerEx dtpEx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CMST.Controls.CbComBoxEx cbComBoxEx1;
        private CMST.Controls.CbComBoxEx cbComBoxEx2;
        private CMST.Controls.CbComBoxEx cbComBoxEx3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnDetail;
        private CMST.Controls.ComboBoxTreeView comboBoxTreeView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CMST.Controls.CbComBoxEx cbComBoxEx4;
    }
}

