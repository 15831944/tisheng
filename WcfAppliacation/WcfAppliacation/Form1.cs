using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
//using WcfAppliacation.StockTakingManage;

namespace WcfAppliacation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public void Instantiation()
        {
            string url = "http://127.0.0.1:8082/StockTakingManage";
            StockTakingManageProxyClient stock = new StockTakingManageProxyClient(GetWSHttpBinding(), new EndpointAddress(url));
            StockModelData.StockModel sm = new StockModelData.StockModel();
            stock.AddStocktakingBill(sm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instantiation();
        }
        private WSHttpBinding GetWSHttpBinding()
        {
            WSHttpBinding wshttpBinding = new WSHttpBinding(SecurityMode.None);
            wshttpBinding.SendTimeout = new TimeSpan(0, 10, 0);
            wshttpBinding.MaxBufferPoolSize = 2147483647;
            wshttpBinding.MaxReceivedMessageSize = 2147483647;
            wshttpBinding.ReaderQuotas.MaxDepth = 2147483647;
            wshttpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
            return wshttpBinding;
        }
    }
}
