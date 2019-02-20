using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class StorageWayEntity
    {
        public int SwaId { get; set; }
        public string SwaName { get; set; }
        public string SwaRemark { get; set; }
        public bool SwaIfUse { get; set; }
        public string SwaIfUse2 { get; set; }
    }
}
