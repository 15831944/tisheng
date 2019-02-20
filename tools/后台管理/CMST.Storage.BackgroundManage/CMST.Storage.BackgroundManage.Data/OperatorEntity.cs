using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{

    public class OperatorEntity
    {

        public int OperatorID { get; set; }

        public string OperatorName { get; set; }

        public string Account { get; set; }

        public string Password {get; set;}

        public int CmstID { get; set; }

        public string CmstName { get; set; }


        public int RoleID { get; set; }


        public string RoleName { get; set; }


        public int DeptId { get; set; }


        public string DepartName { get; set; }

        public int JtyId { get; set; }

        public string JtyName { get; set; }

        public bool IfSysAccount { get; set; }

        public bool IfUse { get; set; }

        public DateTime UpdateTime { get; set; }

    }

}
