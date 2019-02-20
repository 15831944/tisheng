using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public class ButtonEx : Button
    {
        private DataGridView Mydgv = new DataGridView();
        public ButtonEx() { }
        public void SetDgv(DataGridView dgv)
        {
            this.Mydgv = dgv;
        }
        public delegate void ClikcButton(object sender, EventArgs e);

        public event ClikcButton ButtonClick;

        public void GetButton(object sender, EventArgs e)

        {
            if (ButtonClick != null) 
            ButtonClick(sender, new EventArgs());

        }
        protected override void OnClick(EventArgs e)
        { 
            base.OnClick(e);
            GetButton(this, e);
            if (Mydgv.Rows.Count <= 0)
            {
                CMSTMsgBox.MsgBox.ShowDialog("没有数据!!!");
                return;
            }
            string fileName = "";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                CMSTMsgBox.MsgBox.ShowDialog("无法创建Excel对象，可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 


            string[] array = new string[Mydgv.Columns.Count];


            //获取Visble =true 的列  
            foreach (DataGridViewColumn column in Mydgv.Columns)
            {
                if (column.Visible == true)
                {
                    array[column.DisplayIndex] = column.HeaderText + '|' + column.Name;
                }
            }

            int RowsCount = Mydgv.Rows.Count;
            int ColumnsCount = array.Length;
            int mm = 1;
            for (int i = 0; i < ColumnsCount; i++)
            {
                string[] str = new string[2];
                string ColumnName;
                try
                {
                    str = array.GetValue(i).ToString().Split('|');
                    ColumnName = str[0];
                }
                catch
                {
                    continue;
                }
                //导出列名  
                worksheet.Cells[1, mm] = ColumnName;
                //导出列内容  
                for (int m = 0; m < RowsCount; m++)
                {
                    try
                    {
                        worksheet.Cells[m + 2, mm] = Mydgv.Rows[m].Cells[str[1]].FormattedValue.ToString();
                    }
                    catch
                    { }
                }
                mm++;
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            CMSTMsgBox.MsgBox.ShowDialog(fileName + "导出成功", "提示");
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    CMSTMsgBox.MsgBox.ShowDialog("导出文件时出错,文件可能正被打开！\n" + ex.Message);                   
                }
            }
            xlApp.Quit();
            GC.Collect();
        }

}
}
