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
     public class OperationManageService
    {
        OperationManageBLL MyOperationManageBLL = new OperationManageBLL();
        public string SaveOperation(OperationEntity me)
        {
            return JsonConvert.SerializeObject(MyOperationManageBLL.SaveOperation(me));
        }
        public string GetOperationByID(int OperationID)
        {
            return JsonConvert.SerializeObject(MyOperationManageBLL.GetOperationByID(OperationID));
        }
        public string GetAllOperation()
        {
            return JsonConvert.SerializeObject(MyOperationManageBLL.GetAllOperation());
        }
    }
}
