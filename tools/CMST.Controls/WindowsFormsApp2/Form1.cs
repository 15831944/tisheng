using CMST.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
   
   
    
    public partial class Form1 : Form
    {
        public class Customer
        {
            public string CustomerName { get; set; }
            public string ZJ { get; set; }
            public int ID { get; set; }
        }

        public class Goods
        {
            public string Name { get; set; }
            public string Zjm { get; set; }
            public string ID { get; set; }
            public string Order { get; set; }
        }

        List<Customer> cs = new List<Customer>();
        List<Goods> gs = new List<Goods>();
        public Form1()
        {
            InitializeComponent();
            cs = new List<Customer>
            {
                 new Customer{ CustomerName = "谢茂林", ZJ ="xml", ID = 1},
                 new Customer{ CustomerName = "展师傅",ZJ = "zsf", ID = 2},
                 new Customer{ CustomerName = "李洪旭",ZJ = "lhx", ID = 3}
            };
            

            gs = new List<Goods>
            {
                new Goods{ Name ="塑胶",Zjm = "sj",ID="1",Order="1"},
                 new Goods{ Name ="合成橡胶",Zjm = "hcxj",ID="2",Order="2"},
                 new Goods{ Name ="大庆炼化",Zjm = "dqlh",ID="3",Order="3"},
                 new Goods{ Name ="大庆",Zjm = "dq",ID="4",Order="4"}
            };

            //  this.cbComBoxEx1.SetSourceAndAuto(cs.ToList<object>(), "ID", "CustomerName", "CustomerName", "ZJ");
            this.cbComBoxEx1.SetSourceAndAuto(gs.OrderBy(m=>m.Name).ToList<object>(),  "Name", "Name", "Zjm", "Order", "ID");
            this.cbComBoxEx2.SetSourceAndAuto(gs.ToList<object>(),  "Name", "Name", "Zjm", "Order", "ID");
            this.cbComBoxEx3.SetSourceAndAuto(gs.ToList<object>(),  "Name", "Name", "Zjm", "Order", "ID");

            UIOp.Reset(this);

            this.cbComBoxEx1.KeyDown += cbComBoxEx_KeyDown;
            this.cbComBoxEx2.KeyDown += cbComBoxEx_KeyDown;
            this.cbComBoxEx3.KeyDown += cbComBoxEx_KeyDown;
            this.btnDetail.Visible = false;
            this.dataGridView1.Controls.Add(btnDetail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UIOp.IsModify(this))
            {
                MessageBox.Show("数据已修改过!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIOp.Reset(this);
        }

        private void cbCs_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbCs_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void cbComBoxEx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button3_Click(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            Goods ga1 = cbComBoxEx1.SelectedItem as Goods;
            Goods ga2 = cbComBoxEx2.SelectedItem as Goods;
            Goods ga3 = cbComBoxEx3.SelectedItem as Goods;
            MessageBox.Show("查询，" + ga1?.Name + ":" + ga2?.Name + ":" + ga3?.Name);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            btnDetail.Visible = false;
            Rectangle rect = this.dataGridView1.GetCellDisplayRectangle(this.dataGridView1.CurrentCell.ColumnIndex,
                                                                            this.dataGridView1.CurrentCell.RowIndex, false);
            btnDetail.Left = rect.Right - btnDetail.Width;
            btnDetail.Top = rect.Top;
            btnDetail.Height = rect.Height;
            btnDetail.Width = 20;
            btnDetail.Tag = this.dataGridView1.CurrentCell.RowIndex;
            btnDetail.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.cbComBoxEx1.SetDefaultItem("Name", "塑胶");

            this.cbComBoxEx1.SelectedIndex = -1;
 
        }
    }
}
