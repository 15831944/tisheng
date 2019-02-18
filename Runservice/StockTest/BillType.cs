using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace StockModelData

{
    [DataContract]
    public class BillType
    {
        [DataMember]
        [JsonProperty("billTypeId")]
        public int BillTypeID { get; set; }
        [DataMember]
        [JsonProperty("billTypeName")]
        public string BillTypeName { get; set; }
    }

    public class BillTypeTab
    {
        public const string BTY_ID = "Bty_Id";
        public const string BTY_NAME = "Bty_Name";
    }
}