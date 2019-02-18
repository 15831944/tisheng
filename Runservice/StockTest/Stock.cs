using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace StockModelData

{
    public class Stock
    {
        public long StockID { get; set; }
        public int SkuID { get; set; }
        public int SubjectID { get; set; }
        public int? CompanyID { get; set; }
        public int? GalID { get; set; }
        public decimal AN { get; set; }
        public int PN { get; set; }
    }

    [DataContract]
    public class StockInfo
    {
        [DataMember]
        [JsonProperty("stockId")]
        public long StockID { get; set; }

        [DataMember]
        [JsonProperty("companyId")]
        public int CompanyID { get; set; }

        [DataMember]
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [DataMember]
        [JsonProperty("reservoirAreaName")]
        public string ReservoirAreaName { get; set; }

        [DataMember]
        [JsonProperty("galId")]
        public int GalId { get; set; }

        [DataMember]
        [JsonProperty("galDescript")]
        public string GalDescript { get; set; }

        [DataMember]
        [JsonProperty("skuId")]
        public int SkuID { get; set; }

        [DataMember]
        [JsonProperty("skuName")]
        public string SkuName { get; set; }

        [DataMember]
        [JsonProperty("pn")]
        public int PN { get; set; }

        [DataMember]
        [JsonProperty("an")]
        public decimal AN { get; set; }
        [DataMember]
        [JsonProperty("subjectName")]
        public string  SubjectName { get; set; }
    }


    public class StockTab
    {
        public const string STO_ID = "Sto_Id";
        public const string STO_SKU_ID = "Sto_Sku_Id";
        public const string STO_SUB_ID = "Sto_Sub_Id";
        public const string STO_COM_ID = "Sto_Com_ID";
        public const string STO_GAL_ID = "Sto_Gal_Id";
        public const string STO_ACCOUNTINGNUM = "Sto_AccountingNum";
        public const string STO_PACKINGNUM = "Sto_PackingNum";
    }

    [DataContract]
    public class StockInfoInPDAQuery
    {
       
        [DataMember]
        [JsonProperty("depId")]
        public int DepID { get; set; }
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        [JsonProperty("skuName")]
        public string SkuName { get; set; }
        [JsonProperty("rarId")]
        public int RarId { get; set; }
        [JsonProperty("galId")]
        public int GalId { get; set; }
        [JsonProperty("galDescript")]
        public string GalDescript { get; set; }
        [JsonProperty("currentMinId")]
        public long CurrentMinId { get; set; }
        [JsonProperty("requester")]
        public int Requester { get; set; }
    }
}