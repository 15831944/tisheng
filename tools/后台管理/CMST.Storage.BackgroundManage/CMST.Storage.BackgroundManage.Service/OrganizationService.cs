using CMST.Storage.BackgroundManage.BLL;
using CMST.Storage.BackgroundManage.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Service
{
    public class OrganizationService
    {
        OrganizationBLL MyOrganizationBLL = new OrganizationBLL();
        public string GetAllOrganization()
        {
            return JsonConvert.SerializeObject(MyOrganizationBLL.GetAllOrganization());
        }
        public string SaveOrganization(OrganizationEntity oe)
        {
            return JsonConvert.SerializeObject(MyOrganizationBLL.SaveOrganization(oe));
        }
       
    }
}
