using CMST.Storage.BackgroundManage.BLL;
using CMST.Storage.BackgroundManage.Common;
using CMSTMsgBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Storage.BackgroundManage
{
    public partial class FrmDatabase : Form
    {
        public string STATUS_DBTEST_CONNECTED = "已连接";
        public string STATUS_DBTEST_NOCONNECTED = "未连接";
        private string _directory = "Config";
        private string _file = "dbset.xml";
        DataSet ds = new DataSet();
        public FrmDatabase()
        {
            InitializeComponent();
            LoadConfig();
            this.MaximizeBox = false;
            InitDbStatus();
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            string dbip = this.txtDBIp.Text;
            string dbport = this.txtDBPort.Text;
            string dbname = this.txtDBName.Text;
            string dbsa = this.txtDBSa.Text;
            string dbpwd = this.txtDBPwd.Text;
            FeedbackInfomation fi = new FeedbackInfomation();
            fi = DataValidate.ValidateIpAddress(dbip);
            if (fi.ErrorStatus != STATUS_ADAPTER.IP_NORMAL)
            {
                MsgBox.ShowDialog(Tips.DB + fi.FeedbackMessage);
                return;
            }
            DBTestBLL dtbll = new DBTestBLL();
            fi = dtbll.TestDBConnect(dbip, dbport, dbname, dbsa, dbpwd);
            if (fi.ErrorStatus == STATUS_ADAPTER.DB_CONNECT_NORMAL)
            {
                this.labDBStatus.Text = "状态：" + this.STATUS_DBTEST_CONNECTED;
                SetDbStatus();
                //MsgBox.ShowDialog(Tips.DB_CONNECTTEST_SUCCESS);
            }
            else
            {
                this.labDBStatus.Text = this.STATUS_DBTEST_NOCONNECTED;
                MsgBox.ShowDialog(Tips.DB_CONNECTTEST_FAILED);
            }
        }

        private void FrmDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.Yes == MsgBox.ShowDialog("是否保存设置", "", MsgBox.MyButtons.YesNo))
            {
                if (SaveConfig())
                {
                    MsgBox.ShowDialog(Tips.SAVE_SUCCESS);
                }
                else
                {
                    MsgBox.ShowDialog(Tips.SAVE_FAILED);
                }
            }

        }
        public bool SaveConfig()
        {
            try
            {
                ds.Tables[0].Rows[0]["STO_IP"] = this.txtDBIp.Text;
                ds.Tables[0].Rows[0]["STO_Port"] = this.txtDBPort.Text;
                ds.Tables[0].Rows[0]["STO_DBName"] = this.txtDBName.Text;
                ds.Tables[0].Rows[0]["STO_Account"] = this.txtDBSa.Text;
                ds.Tables[0].Rows[0]["STO_Pwd"] = this.txtDBPwd.Text;
                SaveConfigDataSet(ds, this._directory, this._file);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void SaveConfigDataSet(DataSet ds, string directory, string filename)
        {
            string strdir = System.Windows.Forms.Application.StartupPath + "/" + directory;
            string strfile = strdir + "/" + filename;
            if (!Directory.Exists(strdir))
            {
                Directory.CreateDirectory(strdir);
            }
            if (!File.Exists(strfile))
            {
                FileStream fs = File.Create(strfile);
                fs.Close();
            }
            ds.WriteXml(strfile);
        }
        public static DataSet LoadConfigDataSet(string directory, string filename)
        {
            try
            {
                string str = System.Windows.Forms.Application.StartupPath + "/" + directory + "/" + filename;
                DataSet ds = new DataSet();
                ds.ReadXml(str);
                return ds;

            }
            catch
            {
                return null;
            }
        }
        public void LoadConfig()
        {
            string config_path = System.Windows.Forms.Application.StartupPath + "/" + this._directory + "/" + this._file;
            if (!File.Exists(config_path))
            {
                DataSet dsNew = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("STO_IP", typeof(string)));
                dt.Columns.Add(new DataColumn("STO_Port", typeof(string)));
                dt.Columns.Add(new DataColumn("STO_DBName", typeof(string)));
                dt.Columns.Add(new DataColumn("STO_Account", typeof(string)));
                dt.Columns.Add(new DataColumn("STO_Pwd", typeof(string)));
                DataRow dr = dt.NewRow();
                dr["STO_IP"] = "110.249.128.218";
                dr["STO_Port"] = "1433";
                dr["STO_DBName"] = "CMSTStorageDB";
                dr["STO_Account"] = "sa";
                dr["STO_Pwd"] = "Cmst&654321";
                dt.Rows.Add(dr);
                dsNew.Tables.Add(dt);
                SaveConfigDataSet(dsNew, this._directory, this._file);
            }
            ds = LoadConfigDataSet(this._directory, this._file);
            SetView();
        }
        private void SetView()
        {
            this.txtDBIp.Text = ds.Tables[0].Rows[0]["STO_IP"].ToString();
            this.txtDBPort.Text = ds.Tables[0].Rows[0]["STO_Port"].ToString();
            this.txtDBName.Text = ds.Tables[0].Rows[0]["STO_DBName"].ToString();
            this.txtDBSa.Text = ds.Tables[0].Rows[0]["STO_Account"].ToString();
            this.txtDBPwd.Text = ds.Tables[0].Rows[0]["STO_Pwd"].ToString();
        }

        private void nidatabase_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                this.nidatabase.Visible = false;
            }
        }

        private void FrmDatabase_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) //判断是否最小化
            {
                this.nidatabase.Visible = true;
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }
        private void InitDbStatus()
        {
            this.pBoxdatabase.Image = imageListdblogo.Images[0];
            Bitmap iconBm = new Bitmap(imageListdblogo.Images[0], Size);
            Icon ic = Icon.FromHandle(iconBm.GetHicon());
            //Icon ic = new Icon(@"C:\Users\Administrator\Desktop\db1.ico");
            this.Icon = ic;
            this.nidatabase.Icon = ic;
        }
        private void SetDbStatus()
        {
            this.pBoxdatabase.Image = imageListdblogo.Images[1];
            Bitmap iconBm = new Bitmap(imageListdblogo.Images[1], Size);
            Icon ic = Icon.FromHandle(iconBm.GetHicon());
            this.Icon = ic;
            this.nidatabase.Icon = ic;
        }
    }
}


