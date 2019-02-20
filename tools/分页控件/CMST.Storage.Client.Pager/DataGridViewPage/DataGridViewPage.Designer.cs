namespace DataGridViewPage
{
    partial class DataGridViewPage
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bdInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.pageCount = new System.Windows.Forms.ToolStripLabel();
            this.pageFirst = new System.Windows.Forms.ToolStripButton();
            this.PagePrev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.currentCount = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PageNext = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pageLast = new System.Windows.Forms.ToolStripButton();
            this.dgvInfo = new DataGridViewEx();
            this.bsInfo = new System.Windows.Forms.BindingSource(this.components);
            this.btnSetCol = new System.Windows.Forms.Button();
            this._lab_Pagesize = new System.Windows.Forms.Label();
            this.nudPageSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bdInfo)).BeginInit();
            this.bdInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // bdInfo
            // 
            this.bdInfo.AddNewItem = null;
            this.bdInfo.BackColor = System.Drawing.Color.Transparent;
            this.bdInfo.CountItem = this.pageCount;
            this.bdInfo.DeleteItem = null;
            this.bdInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.bdInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bdInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageFirst,
            this.PagePrev,
            this.bindingNavigatorSeparator,
            this.currentCount,
            this.pageCount,
            this.bindingNavigatorSeparator1,
            this.PageNext,
            this.bindingNavigatorSeparator2,
            this.pageLast});
            this.bdInfo.Location = new System.Drawing.Point(79, 0);
            this.bdInfo.MoveFirstItem = this.pageFirst;
            this.bdInfo.MoveLastItem = this.pageLast;
            this.bdInfo.MoveNextItem = this.PageNext;
            this.bdInfo.MovePreviousItem = this.PagePrev;
            this.bdInfo.Name = "bdInfo";
            this.bdInfo.PositionItem = this.currentCount;
            this.bdInfo.Size = new System.Drawing.Size(197, 25);
            this.bdInfo.TabIndex = 0;
            this.bdInfo.Text = "bindingNavigator1";
            // 
            // pageCount
            // 
            this.pageCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageCount.Name = "pageCount";
            this.pageCount.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.pageCount.Size = new System.Drawing.Size(32, 22);
            this.pageCount.Text = "/ {0}";
            this.pageCount.ToolTipText = "总项数";
            // 
            // pageFirst
            // 
            this.pageFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageFirst.Image = ((System.Drawing.Image)(resources.GetObject("pageFirst.Image")));
            this.pageFirst.Name = "pageFirst";
            this.pageFirst.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.pageFirst.RightToLeftAutoMirrorImage = true;
            this.pageFirst.Size = new System.Drawing.Size(23, 22);
            this.pageFirst.Text = "移到第一条记录";
            this.pageFirst.Click += new System.EventHandler(this.pageFirst_Click);
            // 
            // PagePrev
            // 
            this.PagePrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PagePrev.Image = ((System.Drawing.Image)(resources.GetObject("PagePrev.Image")));
            this.PagePrev.Name = "PagePrev";
            this.PagePrev.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.PagePrev.RightToLeftAutoMirrorImage = true;
            this.PagePrev.Size = new System.Drawing.Size(23, 22);
            this.PagePrev.Text = "移到上一条记录";
            this.PagePrev.Click += new System.EventHandler(this.PagePrev_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // currentCount
            // 
            this.currentCount.AccessibleName = "位置";
            this.currentCount.AutoSize = false;
            this.currentCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentCount.Name = "currentCount";
            this.currentCount.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.currentCount.Size = new System.Drawing.Size(50, 23);
            this.currentCount.Text = "0";
            this.currentCount.ToolTipText = "当前位置";
            this.currentCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentCount_KeyDown);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PageNext
            // 
            this.PageNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PageNext.Image = ((System.Drawing.Image)(resources.GetObject("PageNext.Image")));
            this.PageNext.Name = "PageNext";
            this.PageNext.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.PageNext.RightToLeftAutoMirrorImage = true;
            this.PageNext.Size = new System.Drawing.Size(23, 22);
            this.PageNext.Text = "移到下一条记录";
            this.PageNext.Click += new System.EventHandler(this.PageNext_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pageLast
            // 
            this.pageLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageLast.Image = ((System.Drawing.Image)(resources.GetObject("pageLast.Image")));
            this.pageLast.Name = "pageLast";
            this.pageLast.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.pageLast.RightToLeftAutoMirrorImage = true;
            this.pageLast.Size = new System.Drawing.Size(23, 22);
            this.pageLast.Text = "移到最后一条记录";
            this.pageLast.Click += new System.EventHandler(this.pageLast_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToOrderColumns = true;
            this.dgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.EnableHeadersVisualStyles = false;
            this.dgvInfo.Location = new System.Drawing.Point(3, 28);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(505, 319);
            this.dgvInfo.TabIndex = 1;
            this.dgvInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInfo_RowPostPaint);
            // 
            // btnSetCol
            // 
            this.btnSetCol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSetCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetCol.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetCol.Location = new System.Drawing.Point(0, 0);
            this.btnSetCol.Name = "btnSetCol";
            this.btnSetCol.Size = new System.Drawing.Size(70, 25);
            this.btnSetCol.TabIndex = 2;
            this.btnSetCol.Text = "设置列头";
            this.btnSetCol.UseVisualStyleBackColor = true;
            // 
            // _lab_Pagesize
            // 
            this._lab_Pagesize.AutoSize = true;
            this._lab_Pagesize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lab_Pagesize.Location = new System.Drawing.Point(285, 6);
            this._lab_Pagesize.Name = "_lab_Pagesize";
            this._lab_Pagesize.Size = new System.Drawing.Size(80, 17);
            this._lab_Pagesize.TabIndex = 3;
            this._lab_Pagesize.Text = "每页条目数：";
            // 
            // nudPageSize
            // 
            this.nudPageSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudPageSize.Location = new System.Drawing.Point(368, 3);
            this.nudPageSize.Name = "nudPageSize";
            this.nudPageSize.Size = new System.Drawing.Size(51, 23);
            this.nudPageSize.TabIndex = 4;
            this.nudPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPageSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPageSize.ValueChanged += new System.EventHandler(this.nudPageSize_ValueChanged);
            // 
            // DataGridViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nudPageSize);
            this.Controls.Add(this._lab_Pagesize);
            this.Controls.Add(this.btnSetCol);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.bdInfo);
            this.Name = "DataGridViewPage";
            this.Size = new System.Drawing.Size(511, 350);
            ((System.ComponentModel.ISupportInitialize)(this.bdInfo)).EndInit();
            this.bdInfo.ResumeLayout(false);
            this.bdInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdInfo;
        private System.Windows.Forms.ToolStripLabel pageCount;
        private System.Windows.Forms.ToolStripButton pageFirst;
        private System.Windows.Forms.ToolStripButton PagePrev;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox currentCount;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton PageNext;
        private System.Windows.Forms.ToolStripButton pageLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DataGridViewEx dgvInfo;
        private System.Windows.Forms.BindingSource bsInfo;
        private System.Windows.Forms.Button btnSetCol;
        private System.Windows.Forms.Label _lab_Pagesize;
        private System.Windows.Forms.NumericUpDown nudPageSize;
    }
}
