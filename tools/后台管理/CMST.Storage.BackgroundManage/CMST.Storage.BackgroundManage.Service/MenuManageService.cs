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
    public class MenuManageService
    {
        MenuManageBLL MyMenuManageBLL = new MenuManageBLL();
        public string SaveMenu(MenuEntity me)
        {
            return JsonConvert.SerializeObject(MyMenuManageBLL.SaveMenu(me));
        }
        public string GetMenuByID(int menuID)
        {
            return JsonConvert.SerializeObject(MyMenuManageBLL.GetMenuByID(menuID));
        }
        public string GetAllMenu()
        {
            return JsonConvert.SerializeObject(MyMenuManageBLL.GetAllMenu());
        }
    }
}
