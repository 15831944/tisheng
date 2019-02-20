namespace DataGridViewPage
{
    partial class frmSetCol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSetCol = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetCol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSetCol
            // 
            this.dgvSetCol.AllowDrop = true;
            this.dgvSetCol.AllowUserToAddRows = false;
            this.dgvSetCol.AllowUserToDeleteRows = false;
            this.dgvSetCol.AllowUserToResizeColumns = false;
            this.dgvSetCol.AllowUserToResizeRows = false;
            this.dgvSetCol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSetCol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSetCol.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSetCol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSetCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetCol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UI,
            this.Type,
            this.QueryField,
            this.DisplayField,
            this.ColName,
            this.IsVisible,
            this.ColOrder});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSetCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSetCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSetCol.EnableHeadersVisualStyles = false;
            this.dgvSetCol.Location = new System.Drawing.Point(0, 0);
            this.dgvSetCol.MultiSelect = false;
            this.dgvSetCol.Name = "dgvSetCol";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSetCol.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSetCol.RowTemplate.Height = 23;
            this.dgvSetCol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSetCol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSetCol.Size = new System.Drawing.Size(220, 325);
            this.dgvSetCol.TabIndex = 0;
            this.dgvSetCol.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSetCol_CellMouseMove);
            this.dgvSetCol.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSetCol_RowPostPaint);
            this.dgvSetCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvSetCol_DragDrop);
            this.dgvSetCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvSetCol_DragEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // UI
            // 
            this.UI.DataPropertyName = "UI";
            this.UI.HeaderText = "UI";
            this.UI.Name = "UI";
            this.UI.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = false;
            // 
            // QueryField
            // 
            this.QueryField.DataPropertyName = "QueryField";
            this.QueryField.HeaderText = "QueryField";
            this.QueryField.Name = "QueryField";
            this.QueryField.Visible = false;
            // 
            // DisplayField
            // 
            this.DisplayField.DataPropertyName = "DisplayField";
            this.DisplayField.HeaderText = "DisplayField";
            this.DisplayField.Name = "DisplayField";
            this.DisplayField.Visible = false;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "列名";
            this.ColName.Name = "ColName";
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsVisible
            // 
            this.IsVisible.DataPropertyName = "IsVisible";
            this.IsVisible.HeaderText = "是否显示";
            this.IsVisible.Name = "IsVisible";
            this.IsVisible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColOrder
            // 
            this.ColOrder.DataPropertyName = "ColOrder";
            this.ColOrder.HeaderText = "列序";
            this.ColOrder.Name = "ColOrder";
            this.ColOrder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColOrder.Visible = false;
            // 
            // frmSetCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 325);
            this.Controls.Add(this.dgvSetCol);
            this.Name = "frmSetCol";
            this.Text = "设置列头";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetCol_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetCol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryField;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrder;
    }
}