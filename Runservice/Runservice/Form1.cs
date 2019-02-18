using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runservice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WcfServiceStock myHostManage = null;
        private void RunService_Click(object sender, EventArgs e)
        {
            string ip = IP_txt.Text;
            string port = Port_txt.Text;
            string strResult = "";
            myHostManage = new WcfServiceStock(ip, int.Parse(port), "StockService");
           bool IfStartOrNO= myHostManage.RunHostBothHttpAndTcpProtocol(out strResult);

        }
    }
}
