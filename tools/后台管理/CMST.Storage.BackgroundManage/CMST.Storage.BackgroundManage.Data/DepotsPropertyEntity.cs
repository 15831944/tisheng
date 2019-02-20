using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class DepotsPropertyEntity
    {
        public int DprId { get; set; }
        public string DprName { get; set; }
        public string DprRemark { get; set; }
        public bool DprIfUse { get; set; }
        public string DprIfUse2 { get; set; }
    }
}
