using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
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
    public partial class Form2 : Form
    {
        public class Plan
        {
            public long PlanID { get; set; }
            public int Num { get; set; }
            public decimal Weight { get; set; }
           public  List<PrepareGoods> pgs = new List<PrepareGoods>(); 
        }

        public class PrepareGoods
        {
            public long PgID { get; set; }
            public long PlanID { get; set; }
            public int Num { get; set; }
            public decimal Weight { get; set; }
            public string GoodsAllocation { get; set; }
            public string Goods { get; set; }

        }

        public Form2()
        {
            InitializeComponent();
            InitializeGrid();
            BindSgc();
        }

        private Background _Background1 =
         new Background(Color.White, Color.FromArgb(238, 244, 251), 45);

        private Background _Background2 = new Background(Color.FromArgb(249, 249, 234));
        private Background _Background3 = new Background(Color.FromArgb(255, 247, 250));


        private void InitializeGrid()
        {
            GridPanel panel = sgc.PrimaryGrid;

            //panel.Name = "Customers";
            panel.ShowToolTips = false;

            panel.MinRowHeight = 20;
           // panel.AutoGenerateColumns = true;

            panel.DefaultVisualStyles.GroupByStyles.Default.Background = _Background1;

            panel.SelectionGranularity = SelectionGranularity.Cell;


          
        }

        List<Plan> ps = new List<Plan>
            {
                new Plan{ PlanID = 1, Num = 100,Weight=1000, pgs = new List<PrepareGoods>{
                    new PrepareGoods{ PgID=1, PlanID=1, Num=10,Weight=1000, Goods ="橡胶", GoodsAllocation ="1号货位"},
                    new PrepareGoods{ PgID=2, PlanID=1, Num=10,Weight=1000, Goods ="塑料", GoodsAllocation ="1号货位"},
                    new PrepareGoods{ PgID=3, PlanID=1, Num=10,Weight=1000, Goods ="树脂", GoodsAllocation ="1号货位"}
                } },

            };
        private void BindSgc()
        {
            DataSet ds = new DataSet();
           

            

            this.sgc.PrimaryGrid.DataSource = ps;
            this.sgc.PrimaryGrid.Name = "ps";
           
            

         
            ///    this.sgc.PrimaryGrid.FindGridPanel("").Columns.Add(gc);
            // this.sgc.PrimaryGrid.LastOnScreenRow.GridPanel.Columns.Add(gc);
            this.sgc.DataBindingComplete += (o, e) =>
            {
                GridPanel gp = e.GridPanel;
                gp.ShowRowGridIndex = true;
                switch (gp.Name)
                {
                    case "ps":

                        this.sgc.PrimaryGrid.Columns["Num"].HeaderText = "应发数量";
                        this.sgc.PrimaryGrid.Columns["Weight"].HeaderText = "应发重量";
                        this.sgc.PrimaryGrid.Columns["PlanID"].HeaderText = "应发关联配货";
                        break;
                    case "pgs":                      
                        gp.GridPanel.Columns["Goods"].HeaderText = "物资";
                        gp.GridPanel.Columns["PgID"].Visible = false;
                        gp.GridPanel.Columns["PlanID"].Visible = false;
                        gp.GridPanel.Columns["Num"].HeaderText = "配货数量";
                        gp.GridPanel.Columns["Weight"].HeaderText = "配货重量";
                        gp.GridPanel.Columns["GoodsAllocation"].HeaderText = "货位";
                        gp.AllowEdit = false;
                        break;
                }
             
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //             ps.Add(
            //                 new Plan { PlanID = 2, Num = 100, Weight = 1000, pgs = new List<PrepareGoods>{
            //                     new PrepareGoods{ PgID=1, PlanID=2, Num=10,Weight=1000, Goods ="橡胶", GoodsAllocation ="1号货位"}
            //                 } }
            //             );
            //             this.sgc.PrimaryGrid.DataSource = ps;
            //             this.sgc.PrimaryGrid.Name = "ps";
            this.panel1.Location = new Point(0, 0);
        }
    }
}
