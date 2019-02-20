using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SqlDataHelper.SetConnStr("127.0.0.1", "1433", "TestDB", "sa", "123");
            InitMcdTypeTree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlDataHelper.GetConnection();
      
            Stopwatch sw = new Stopwatch();
            string sqlstr = "select top 10 * from TestTab";
            sw.Start();
            conn.Open();
            DataSet ds = SqlDataHelper.ExecuteDataSet(conn, CommandType.Text, sqlstr);
            conn.Close();
            sw.Stop();

            MessageBox.Show("ds:" + sw.Elapsed.TotalMilliseconds);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            conn.Open();
            DataTable dt = SqlDataHelper.ExecuteDataTable(conn, sqlstr ,null);
            conn.Close();
            sw2.Stop();

            MessageBox.Show("dt:" + sw2.Elapsed.TotalMilliseconds);

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            conn.Open();
            DataTable dtt = new DataTable();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            dtt.Load(sdr);
            conn.Close();
            sw3.Stop();
            MessageBox.Show("sdr:" + sw3.Elapsed.TotalMilliseconds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sSou = textBox1.Text;
            Encoding CnEnconding = Encoding.GetEncoding("GB2312");
            byte[] bSou = CnEnconding.GetBytes(sSou); //转成数组   
            for (int i = 0; i < bSou.Length; i++)
            {
                string strvalue = convertting(bSou[i].ToString(), 10, 2);
                if (strvalue.Length <= 8)
                {
                    int cha = 8 - strvalue.Length;
                    for (int j = 0; j < cha; j++)
                    {
                        strvalue = strvalue.Insert(0, "0");
                    }
                }
                textBox1.Text = textBox1.Text + strvalue; //依次取得   
            }
        }

        public string convertting(string value, int baseform, int tobase)
        {
            long intvalue = Convert.ToInt64(value, baseform);
            return Convert.ToString(intvalue, tobase);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str2 = textBox1.Text.Trim();
            for (int x = 0; x < str2.Length; x++)
            {
                if (str2.Substring(0, 1) == "0")
                {
                    string str0 = str2.Substring(x, 8);
                    string shijinzhi = convertting(str0, 2, 10);
                    textBox2.Text = textBox2.Text + Convert.ToChar(Convert.ToInt32(shijinzhi)).ToString();
                    x = x + 7;
                }
                else
                {
                    string str0 = str2.Substring(x, 16);
                    string shijinzhi = convertting(str0, 2, 10);
                    textBox2.Text = textBox2.Text + Convert.ToChar(Convert.ToInt32(shijinzhi));
                    x = x + 15;
                }
            }
        }

        class ss
        {
           public  DateTime Name { get; set; }
            public int a { get; set; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //             string s = textBox1.Text;
            //             string st = string.Empty;
            //             byte[] array = System.Text.Encoding.Default.GetBytes(s);
            //             for (int i = 0; i < array.Length; i++)
            //             {
            //                 if (array[i] >= 128 && array[i] <= 247)
            //                 {
            //                     st = st + System.Text.Encoding.Default.GetString(array, i, 2);
            //                     st = st + string.Format(" 高字节:{0},低字节:{1}" + Environment.NewLine, array[i], array[i + 1]);
            //                     i++;
            //                 }
            //                 else
            //                 {
            //                     st = st + System.Text.Encoding.Default.GetString(array, i, 1);
            //                     st = st + string.Format(" ASCII:{0}" + Environment.NewLine, array[i]);
            //                 }
            //             }
            //             textBox2.Text = st;
            ss a = new ss();
          //  a.Name = Convert.ToDateTime(new DateTime(2017, 1, 1).ToString("yyyy-MM-dd HH:mm:ss"));
            a.a = 123;
            string json = JsonConvert.SerializeObject(a);
            
        }


        private void InitMcdTypeTree()
        {
            comboBoxTreeView1.TreeView.Nodes.Add("一级");
            comboBoxTreeView1.TreeView.Nodes[0].Nodes.Add("1-1货位");
            comboBoxTreeView1.TreeView.Nodes[0].Nodes.Add("1-2货位");
            comboBoxTreeView1.TreeView.Nodes.Add("二级");
            comboBoxTreeView1.TreeView.Nodes[1].Nodes.Add("2-1货位");
            comboBoxTreeView1.TreeView.Nodes[1].Nodes.Add("2-2货位");
            comboBoxTreeView1.TreeView.Nodes.Add("三级");
            comboBoxTreeView1.TreeView.Nodes[2].Nodes.Add("3-1货位");
            comboBoxTreeView1.TreeView.Nodes[2].Nodes.Add("3-1货位");

        }

        /// <summary>  
        /// 递规添加TreeView节点  
        /// </summary>  
        /// <param name="node"></param>  
        /// <param name="parentID"></param>  
        public void addNode(TreeNode node, string parentID)
        {
           
        }
    }
}
