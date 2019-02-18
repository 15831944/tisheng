using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StockModelData
{
    [DataContract]
    public class StockModel
    {
        [DataMember]
        [JsonProperty("StocktakingId")]
         public long StocktakingID { get; set; }
        [DataMember]
        [JsonProperty("cmstId")]
        public int CmstID { get; set; }
        [DataMember]
        [JsonProperty("depotId")]
        public int? DepotID { get; set; }
        [JsonProperty("depotName")]
        public string DepotName { get; set; }

        [DataMember]
        [JsonProperty("reservoirId")]
        public int? ReservoirID { get; set; }
        [DataMember]
        [JsonProperty("reservoirName")]
        public string ReservoirName { get; set; }
        [DataMember]
        [JsonProperty("companyId")]
        public int? CompanyID { get; set; }
        [DataMember]
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        [DataMember]
        [JsonProperty("maker")]
        public int Maker { get; set; }
        [DataMember]
        [JsonProperty("makerName")]
        public string MakerName { get; set; }
        [DataMember]
        [JsonProperty("makeTime")]
        public DateTime MakeTime { get; set; }
        [DataMember]
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("statusName")]
        public string StatusName { get; set; }

    }
    [DataContract]
    public class StocktakingBillDetail
    {
        [DataMember]
        public long StocktakingDetailID { get; set; }
        [DataMember]
        public long StocktakingID { get; set; }
        [DataMember]
        public int CompanyID { get; set; }
        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string DepotName { get; set; }

        [DataMember]
        public string ReservoirName { get; set; }

        [DataMember]
        public int GalID { get; set; }
        [DataMember]
        public string GalName { get; set; }
        [DataMember]
        public string GalDescript { get; set; }
        [DataMember]
        public int SkuID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string GoodsName { get; set; }
        [DataMember]
        public string Spec { get; set; }
        [DataMember]
        public string Grade { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public string Packaging { get; set; }
        [DataMember]
        public string SignType { get; set; }
        [DataMember]
        public string SignNum { get; set; }
        [DataMember]
        public string Spare { get; set; }

        [DataMember]
        public int PN { get; set; }
        [DataMember]
        public decimal AN { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string StatusName { get; set; }
        [DataMember]
        public int? ResultStatus { get; set; }
        [DataMember]
        public string ResultStatusName { get; set; }
        [DataMember]
        public int? Checker { get; set; }
        [DataMember]
        public string CheckName { get; set; }
        [DataMember]
        public DateTime? CheckTime { get; set; }
        [DataMember]
        public string Remark { get; set; }
    }

    [DataContract]
    public class StocktakingQuery
    {
        [DataMember]
        [JsonProperty("cmstId")]
        public int CmstID { get; set; }
        [DataMember]
        [JsonProperty("depotId")]
        public int DepotID { get; set; }
        [DataMember]
        [JsonProperty("companyId")]
        public int CompanyID { get; set; }
        [DataMember]
        [JsonProperty("reservoirId")]
        public int ReservoirID { get; set; }
        [DataMember]
        [JsonProperty("galId")]
        public int GalID { get; set; }
        [DataMember]
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }
        [DataMember]
        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }
        [DataMember]
        [JsonProperty("requester")]
        public int Requester { get; set; }
        [DataMember]
        [JsonProperty("currentMinId")]
        public long CurrentMinID { get; set; }
    }
}
