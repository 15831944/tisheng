using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CMST.Storage.Client.UIMatch;
using DataGridViewPage;

namespace DataGridViewPage
{
    public partial class DataGridViewPage : UserControl
    {
        public DataGridViewEx DgvPageView
        {
            get { return this.dgvInfo; }
        }

        public Color BDBackColor
        {
            get { return this.bdInfo.BackColor; }
            set { this.bdInfo.BackColor = value; }
        }

        public BindingNavigator BnPageTools
        {
            get { return this.bdInfo; }
        }
        public Label LabPageSize {
            get { return this._lab_Pagesize; }
        }
        public NumericUpDown NudPageSize {
            get { return this.nudPageSize; }
        }
        public enum FormatType
        {
            Int,
            Time,
            Normal,
            Double,
        }

       

        public class ColFormat
        {
            public FormatType Type { get; set; }
            public string ColName { get; set; }
            public string FormatString { get; set; }

        }

        public List<ColFormat> Cfs = new List<ColFormat>();

        public int PageSize
        {
            get { return Convert.ToInt32(this.nudPageSize.Value); }
        }
        public int CurPage
        {
            get { return Convert.ToInt32(this.currentCount.Text); }
        }
        public int PgCount
        {
            get { return this.PageCount; }
        }
        public frmSetCol FrmCol;

        private int PageCount = 0;

        private int CurrentPage = 0;
        private int PageFirst = 1;
        private int PageLast = 0;

        private int TotalRecords = 0;

        private string pagecounttext = " / {0}";

        public delegate void SetColumns();
        public SetColumns SetColStyle;
        public DataGridViewPage()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //UpdateStatus.Continue;  
            UpdateStyles();
            this.btnSetCol.Visible = false;
            this.bdInfo.Visible = false;
            this._lab_Pagesize.Visible = false;
            this.nudPageSize.Visible = false;
        }

        public void InitPageInfo(int recordcount, int pagecount)
        {
            if (pagecount > 0)
            {
                this.TotalRecords = recordcount;
                this.CurrentPage = 1;
                this.PageCount = pagecount;
                this.currentCount.Text = "1";
                this.PageFirst = 1;
                this.PageLast = PageCount;
                this.pageCount.Text = string.Format(pagecounttext, pagecount);
                if (PageCount == 1)
                {
                    this.bdInfo.Enabled = false;
                    this.PageNext.Enabled = false;
                    this.pageCount.Enabled = false;
                    this.pageFirst.Enabled = false;
                    this.PagePrev.Enabled = false;
                    this.currentCount.Enabled = false;
                    this.pageLast.Enabled = false;
                }
                else
                {
                    this.bdInfo.Enabled = true;
                    this.PageNext.Enabled = true;
                    this.pageCount.Enabled = true;
                    this.pageFirst.Enabled = true;
                    this.PagePrev.Enabled = true;
                    this.currentCount.Enabled = true;
                    this.pageLast.Enabled = true;
                }
            }
        }

        public Button BtnSetCol
        {
            get { return this.btnSetCol; }
        }

        public delegate void GetPageData(int currentpage, int pagesize, int pagecount);
        public GetPageData getPageData = null;

        private void PageNext_Click(object sender, EventArgs e)
        {
            if (PageCount > 0)
            {
                this.CurrentPage++;
                if (CurrentPage > PageCount)
                {
                    CurrentPage--;
                    return;
                }
                //     DisablePage();
                getPageData(CurrentPage, Convert.ToInt32(nudPageSize.Value), PageCount);
                //     EnablePage();
                this.currentCount.Text = this.CurrentPage.ToString();
                SetControlState();
            }
        }

        private void PagePrev_Click(object sender, EventArgs e)
        {
            if (PageCount > 0)
            {
                this.CurrentPage--;
                if (CurrentPage < PageFirst)
                {
                    CurrentPage++;
                    return;
                }
                //    DisablePage();
                getPageData(CurrentPage, Convert.ToInt32(nudPageSize.Value), PageCount);
                //     EnablePage();
                this.currentCount.Text = this.CurrentPage.ToString();
                SetControlState();
            }
        }
        private void SetControlState()
        {
            this.PageNext.Enabled = true;
            this.pageFirst.Enabled = true;
            this.PagePrev.Enabled = true;
            this.pageLast.Enabled = true;
            if (CurrentPage == 1)
            {
                this.pageFirst.Enabled = false;
                this.PagePrev.Enabled = false;
            }
            else if (CurrentPage == PageCount)
            {

                this.PageNext.Enabled = false;
                this.pageLast.Enabled = false;
            }

        }
        private void DisablePage()
        {
            this.Enabled = false;
        }

        private void EnablePage()
        {
            this.Enabled = true;
        }

        public string pattern = @"^[0-9]*$";
        private void currentCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (PageCount > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Match m = Regex.Match(this.currentCount.Text, pattern);
                    if (!m.Success)
                    {
                        MessageBox.Show("请输入数字");
                        this.currentCount.Text = CurrentPage.ToString();
                        return;
                    }
                    int tempindex = CurrentPage;
                    CurrentPage = Convert.ToInt32(this.currentCount.Text);
                    if (CurrentPage > PageCount || CurrentPage < 0)
                    {
                        MessageBox.Show("页数超过范围");
                        CurrentPage = tempindex;
                        return;
                    }
                    //     DisablePage();
                    getPageData(CurrentPage, Convert.ToInt32(nudPageSize.Value), PageCount);
                    //     DisablePage();
                    this.currentCount.Text = this.CurrentPage.ToString();
                }
            }
        }

        private void pageFirst_Click(object sender, EventArgs e)
        {
            if (PageCount > 0)
            {
                this.CurrentPage = 1;
                //   DisablePage();
                getPageData(CurrentPage, Convert.ToInt32(nudPageSize.Value), PageCount);
                //     DisablePage();
                this.currentCount.Text = this.CurrentPage.ToString();
                SetControlState();
            }
        }

        private void pageLast_Click(object sender, EventArgs e)
        {
            this.CurrentPage = PageCount;
            //  DisablePage();
            getPageData(CurrentPage, Convert.ToInt32(nudPageSize.Value), PageCount);
            // DisablePage();
            this.currentCount.Text = this.CurrentPage.ToString();
            SetControlState();
        }

        public bool IsAddSum;
        private List<object[]> lastRow = new List<object[]>();
        private int colindex = 0;
        private DataTable dtTemp = null;
        private void dgvInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {            
            if (IsAddSum)
            {
                if (e.RowIndex == this.dgvInfo.RowCount - 1)
                {
                    DataGridViewRow row = this.dgvInfo.Rows[this.dgvInfo.RowCount - 1];
                    row.Tag = "Sum";
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    row.HeaderCell.Value = "合计";
                    return;
                }             
            }
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvInfo.RowHeadersWidth - 4, e.RowBounds.Height);
            int rownum = (CurrentPage - 1) * Convert.ToInt32(this.nudPageSize.Value) + e.RowIndex + 1;
            //TextRenderer.DrawText(e.Graphics, (rownum).ToString(), dgvInfo.RowHeadersDefaultCellStyle.Font, rectangle, dgvInfo.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsAddSum)
            {
                if (e.RowIndex >= 0 || this.dgvInfo.Rows.Count == 0 || e.ColumnIndex < 0)
                {
                    return;
                }
                if (lastRow.Count == 0)
                {
                    colindex = e.ColumnIndex;
                    int index = this.dgvInfo.Rows.Count - 1;
                    lastRow.Add(dtTemp.Rows[index].ItemArray);
                    dtTemp.Rows.Remove(dtTemp.Rows[dtTemp.Rows.Count - 1]);
                }
            }
        }

        private void dgvInfo_Sorted(object sender, EventArgs e)
        {
            if (IsAddSum)
            {
                if (lastRow.Count == 0)
                {
                    return;
                }
                DataTable dt = dtTemp;
                DataView dv = dt.DefaultView;
                dv.Sort = dt.Columns[colindex].ColumnName+" desc";
                SortOrder so = this.dgvInfo.SortOrder;
                if (so == SortOrder.Ascending)
                {
                    dv.Sort = dt.Columns[colindex].ColumnName + " asc";
                } else if (so==SortOrder.Descending) {
                    dv.Sort = dt.Columns[colindex].ColumnName + " desc";
                }
                dt = dv.ToTable();
                dt.Rows.Add(lastRow[0]);
                dtTemp.Rows.Add(lastRow[0]);
                lastRow.Clear();
                this.dgvInfo.Rows.Clear();
                setDgvRowInfo(dt);
                
                this.dgvInfo.RowPostPaint += dgvInfo_RowPostPaint;
            }
        }
        //private void dgvInfo_CellClick(object sender,DataGridViewCellEventArgs e) {
        //    drTemp = dtTemp.Rows[dtTemp.Rows.Count - 1];
        //    colindex = e.ColumnIndex;
        //    dgvInfo.Rows.Remove(dgvInfo.Rows[dgvInfo.Rows.Count - 1]);
        //}

        //private void dgvInfo_Sorted(object sender, EventArgs e) {
        //    ListSortDirection sortDirection = ListSortDirection.Ascending;
        //    if (dgvInfo.SortedColumn != null &&
        //        dgvInfo.SortedColumn.Equals(dgvInfo.Columns[colindex]))
        //    {
        //        sortDirection =
        //            dgvInfo.SortOrder == SortOrder.Ascending ?
        //            ListSortDirection.Descending : ListSortDirection.Ascending;
        //    }
        //    this.dgvInfo.Rows.Add();
        //    DataGridViewRow dgvr = this.dgvInfo.Rows[this.dgvInfo.RowCount - 1];
        //    setDgvRowInfo(dgvr, drTemp);
        //    //dgvInfo.Sort(dgvInfo.Columns[colindex], sortDirection);
        //}

        private void setDgvRowInfo(DataTable dt) {
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    this.dgvInfo.Rows.Add();
                    for (int j = 0; j < dgvInfo.Columns.Count; j++)
                    {
                        string colName = this.dgvInfo.Columns[j].Name;
                        var cf = Cfs.Find(m => m.ColName == colName);
                        if (dt.Columns.Contains(colName))
                        {
                            if (cf != null)
                            {
                                switch (cf.Type)
                                {
                                    case FormatType.Time:
                                        if (dr[colName] != null && dr[colName].ToString() != "")
                                        {
                                            dgvInfo.Rows[i].Cells[colName].Value = Convert.ToDateTime(dr[colName]).ToString(cf.FormatString);
                                        }
                                        break;
                                    case FormatType.Double:
                                        if (dr[colName] != null && dr[colName].ToString() != "")
                                        {
                                            dgvInfo.Rows[i].Cells[colName].Value = Convert.ToDouble(dr[colName]).ToString(cf.FormatString);
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                dgvInfo.Rows[i].Cells[colName].Value = dr[colName]?.ToString();
                            }
                        }
                    }
                }
            }
        }

        public void SetDgvInfo(DataTable dt, DataSet dsCol)
        {
            if (dsCol != null)
            {
                this.dgvInfo.RowPostPaint -= dgvInfo_RowPostPaint;
                this.dgvInfo.CellClick += dgvInfo_CellClick;
                this.dgvInfo.Sorted += dgvInfo_Sorted;
                this.dgvInfo.RowPostPaint += (o, e) =>
                {
                    if (IsAddSum)
                    {
                        this.dgvInfo.RowHeadersWidth = 63;
                        if (e.RowIndex == this.dgvInfo.RowCount - 1)
                        {
                            DataGridViewRow row = this.dgvInfo.Rows[this.dgvInfo.RowCount - 1];
                            row.Tag = "Sum";
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                            row.HeaderCell.Value = "合计";
                            return;
                        }
                    }
                    System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvInfo.RowHeadersWidth - 4, e.RowBounds.Height);
                    TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvInfo.RowHeadersDefaultCellStyle.Font, rectangle, dgvInfo.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
                };
                if (dsCol.Tables.Count > 0)
                {
                    this.dgvInfo.Columns.Clear();
                    this.dgvInfo.Rows.Clear();
                    for (int i = 0; i < dsCol.Tables[0].Rows.Count; i++)
                    {
                        DataRow dr = dsCol.Tables[0].Rows[i];
                        bool isvisible = Convert.ToBoolean(dr["IsVisible"]);
                        if (isvisible && !dr["DisplayField"].ToString().Contains("DefaultID"))
                        {
                            DataGridViewColumn dgvc = new DataGridViewTextBoxColumn( );
                            dgvc.Name = dr["DisplayField"].ToString();
                            dgvc.HeaderText = dr["Name"].ToString();
                            dgvc.DisplayIndex = i;
                            this.dgvInfo.Columns.Add(dgvc);
                        }
                        else if (dr["DisplayField"].ToString().Contains("DefaultID"))
                        {
                            DataGridViewColumn dgvc = new DataGridViewTextBoxColumn();
                            dgvc.Name = dr["DisplayField"].ToString();
                            dgvc.HeaderText = dr["Name"].ToString();
                            dgvc.DisplayIndex = i;
                            dgvc.Visible = false;
                            this.dgvInfo.Columns.Add(dgvc);
                        }
                    }
                }
                if (SetColStyle != null)
                {
                    SetColStyle();
                }
                dtTemp = dt;
                setDgvRowInfo(dt);
            }
        }

        public void SetDgvInfo(DataTable dt, DataSet dsCol, int Records, int PageCount)
        {
            this.InitPageInfo(Records, PageCount);
            if (SetColStyle != null)
            {
                SetColStyle();
            }
            this.dgvInfo.DataSource = dt;
            if (dt == null)
            {
                this.currentCount.Text = Convert.ToString(0);
                this.PageCount = 0;
                this.pageCount.Text = string.Format(pagecounttext, PageCount);
                this.bdInfo.Enabled = false;
                this.PageNext.Enabled = false;
                this.pageCount.Enabled = false;
                this.pageFirst.Enabled = false;
                this.PagePrev.Enabled = false;
                this.currentCount.Enabled = false;
                this.pageLast.Enabled = false;
            }
            else
            {
                SetDataView.SetColMartchName(dsCol, this.dgvInfo);
            }
//             if (this.dgvInfo.Columns.Contains("DefaultID"))
//             {
//                             
//             }
            foreach(DataGridViewColumn col in dgvInfo.Columns)
            {
                if (col.Name.Contains("DefaultID"))
                {
                    col.Visible = false;
                }
            }
//             if (this.dgvInfo.Columns.Contains("DefaultID1"))
//             {
//                 this.dgvInfo.Columns["DefaultID1"].Visible = false;
//             }

        }

        private void nudPageSize_ValueChanged(object sender, EventArgs e)
        {
            if (this.nudPageSize.Value <= 0)
            {
                MessageBox.Show("页面条目数必须大于0");
                this.nudPageSize.Value = 20;
                return;
            }
        }
        
    }
}
