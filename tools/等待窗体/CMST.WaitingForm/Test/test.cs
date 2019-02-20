using CMST.WaitingForm;
using MyProgressBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        long sum;
        private void button1_Click(object sender, EventArgs e)

        { 
            frmWaitingBox fw = new frmWaitingBox();
            fw.StartWait();
            for (long i = 0; i < 1000000000; i++)
            {
                sum += i;
                //i++;
            }
            this.tbsum.Text = sum.ToString();
            fw.EndWait();
           
        }
    }
}
