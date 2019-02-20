using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class RateTypeEntity
    {
        public int RtyId { get; set; }
        public string RtyName { get; set; }
        public string RtyRemark { get; set; }
        public bool RtyIfUse { get; set; }
        public string RtyIfUse2 { get; set; }
    }
}
