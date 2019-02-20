using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class OperationEntity
    {
        public int OperationID { get; set; }
        public int CsyID { get; set; }
        public int MenuID { get; set; }
        public string OperateName { get; set; }
        public string OperateUrl { get; set; }
    }
}
