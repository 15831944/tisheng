using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
     public class MenuEntity
    {
        public int MenuID { get; set; }
        public int CsyID { get; set; }
        public string MenuName { get; set; }
        public int FatherID { get; set; }
        public int Rank { get; set; }
        public string Url { get; set; }
    }
}
