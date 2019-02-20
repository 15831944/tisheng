using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        string sql = "select * from UIDisplay where  UI = 'frmProcessingDocuments' order By ID";
        string connstr = "Server=110.249.131.138;DataBase=CMSTStorageDB;User Id=sa;Password=Cmst&654321;Pooling=true;connection lifetime=0;Min Pool Size = 1;Max Pool Size=40000";
        public Form1()
        {
            InitializeComponent();

            QueryData();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            sda.Update(ds.Tables[0]);
            ds.Tables[0].AcceptChanges();
            MessageBox.Show("提交成功");
            if (conn.State != ConnectionState.Closed)
                conn.Close();
            QueryData();
        }
        
        public void QueryData()
        {
            try
            {
                conn = new SqlConnection(connstr);
                sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(sql, conn);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                ds = new DataSet();
                sda.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {

            }
        }
    }
}
