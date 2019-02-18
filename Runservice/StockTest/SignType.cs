using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace StockModelData

{
    [DataContract]
    public class SignType
    {
        [DataMember]
        [JsonProperty("signTypeId")]
        public int SignTypeID { get; set; }

        [DataMember]
        [JsonProperty("signTypeName")]
        public string SignTypeName { get; set; }
    }

    public class SignTypeTab
    {
        public const string STY_ID = "Sty_Id";
        public const string STY_NAME = "Sty_Name";
    }
}