using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFExample.ServiceClient;
namespace WCFExample.ServiceClientTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              Add();
        }

        protected  void Add()
        {
            decimal a = 10;
            decimal b = 20;
            string url = System.Configuration.ConfigurationManager.AppSettings["WCFAddress"];
            ServiceProxy serviceProxy = new ServiceProxy(url);
            Response.Write(serviceProxy.Add(a,b));
        }
    }
}