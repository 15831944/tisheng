using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewPage
{
    public partial class frmSetCol : Form
    {
        private bool isSave = false;

        public bool IsSave
        {
            get { return this.isSave; }
        }
        public frmSetCol()
        {
            InitializeComponent();
            this.dgvSetCol.Columns["IsVisible"].ReadOnly = false;
            this.dgvSetCol.Columns["ColOrder"].ReadOnly = true;
            this.dgvSetCol.Columns["ColName"].ReadOnly = true;
        }

        public DataGridView DgvSetCol
        {
            set { this.dgvSetCol = value; }
            get { return this.dgvSetCol; }
        }
        private DataTable dt = new DataTable();

        public DataSet DsResult
        {
            get {
                if (drDefault != null)
                {
                    foreach(DataRow dr in drDefault)
                    {

                        dt.Rows.Add(dr.ItemArray);
                    }
                }
                return dt.DataSet.Copy();

            }
        }

        List<DataRow> drDefault = null;
        public void SetSource(DataSet ds)
        {
            beforeSetSource();
            dt = ds.Tables[0];           
            for(int i = 0; i < dt.Rows.Count; i++)
            {               
                for(int j = 0;j < dt.Rows.Count - i - 1; j++)
                {
                    if (Convert.ToInt32(dt.Rows[j]["ColOrder"]) > Convert.ToInt32(dt.Rows[j + 1]["ColOrder"]))
                    {
                        DataRow drtemp = dt.NewRow();
                        drtemp.ItemArray = dt.Rows[j].ItemArray;
                        dt.Rows[j].ItemArray = dt.Rows[j + 1].ItemArray;
                        dt.Rows[j + 1].ItemArray = drtemp.ItemArray;
                    }
                }
            }
          /*  for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DisplayField"].ToString().Contains("DefaultID"))
                {
                    drDefault = dt.NewRow();
                    drDefault.ItemArray = dt.Rows[i].ItemArray;
                    dt.Rows.RemoveAt(i);
                }
            }*/
            DataRow[] drDel=   dt.AsEnumerable().Where(m => m.Field<string>("DisplayField").Contains("DefaultID")).ToArray();
          
            if (drDel != null)
            {
                drDefault = new List<DataRow>();
                foreach (DataRow dr in drDel)
                {
                    DataRow drr = dt.NewRow();
                    drr.ItemArray = dr.ItemArray;
                    drDefault.Add(drr);
                    dt.Rows.Remove(dr);
                }
            }
            ds.Tables.Clear();
            ds.Tables.Add(dt);
            this.dgvSetCol.DataSource = dt;
           
            AfterSetSource();
        }

        private void beforeSetSource()
        {
            this.dgvSetCol.CellContentClick -= this.dgvSetCol_CellContentClick;
        }

        private void AfterSetSource()
        {
            this.dgvSetCol.CellContentClick += this.dgvSetCol_CellContentClick;
        }

        private void dgvSetCol_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;
            selectionIdx = GetRowFromPoint(e.X, e.Y);
        }

        private void dgvSetCol_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Clicks < 2) && (e.Button == MouseButtons.Left))
            {
                if ((e.ColumnIndex == -1) && (e.RowIndex > -1))
                {
                    dgvSetCol.DoDragDrop(dgvSetCol.Rows[e.RowIndex], DragDropEffects.Move);
                }
            }
        }
        int selectionIdx = 0;
        private void dgvSetCol_DragDrop(object sender, DragEventArgs e)
        {
            int idx = GetRowFromPoint(e.X, e.Y); 
            if (idx < 0) return;

            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                if (selectionIdx != idx)
                {
                    DataRow drOrigin = dt.NewRow();
                    drOrigin.ItemArray = dt.Copy().Rows[selectionIdx].ItemArray;
                    dt.Rows.Remove(dt.Rows[selectionIdx]);
                    dt.Rows.InsertAt(drOrigin, idx);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["ColOrder"] = i;
                    }
                    this.dgvSetCol.DataSource = dt;
                    dgvSetCol.ClearSelection();
                   
                }
            }
        }

        private int GetRowFromPoint(int x, int y)
        {
            for (int i = 0; i < dgvSetCol.RowCount; i++)
            {
                Rectangle rec = dgvSetCol.GetRowDisplayRectangle(i, false);

                if (dgvSetCol.RectangleToScreen(rec).Contains(x, y))
                    return i;
            }
            return -1;
        }



        private void frmSetCol_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("是否保存？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes)
            {
                this.isSave = true;
            }
            else
            {
                this.isSave = false;
            }
        }


        private void dgvSetCol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSetCol.Columns["IsVisible"].Index)
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    dt.Rows[e.RowIndex][e.ColumnIndex] = dgvSetCol.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                }
            }
        }

        private void dgvSetCol_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvSetCol.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvSetCol.RowHeadersDefaultCellStyle.Font, rectangle, dgvSetCol.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
