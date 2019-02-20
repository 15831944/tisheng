using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class OrganizationEntity
    {
        public int CmstID { get; set; }
        public string CmstName { get; set; }
        public string CmstSysAccount { get; set; }
        public bool CmstIfUse { get; set; }
        public string CmstState { get; set; }
    }
}
