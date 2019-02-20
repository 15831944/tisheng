using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class RoleEntity
    {
        public int RoleID { get; set; }

        public int CmstID { get; set; }

        public int CsyID { get; set; }

        public string RoleName { get; set; }

        public string Remark { get; set; }

        public bool IfUse { get; set; }

        public List<RoleOperations> Ros { get; set; }
    }

    public class RoleOperations
    {

        public int OperationCode { get; set; }


        public int RoleID { get; set; }


        public string RoleName { get; set; }


        public int OperationID { get; set; }


        public string OperationName { get; set; }


        public int CmstID { get; set; }


        public string CmstName { get; set; }
    }
}
