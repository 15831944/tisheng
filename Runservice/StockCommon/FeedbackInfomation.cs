using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace StockCommon
{
    [DataContract]
    public class FeedbackInfomation
    {
        [JsonProperty("result")]
        [DataMember]
        public object Result { get; set; }
        [JsonProperty("errorStatus")]
        [DataMember]
        public STATUS_ADAPTER ErrorStatus { get; set; }
        [JsonProperty("feedbackMessage")]
        [DataMember]
        public string FeedbackMessage { get; set; }

        public FeedbackInfomation SetFi(object o, STATUS_ADAPTER sa, string tips)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            fi.Result = o;
            fi.ErrorStatus = sa;
            fi.FeedbackMessage = tips;
            return fi;
        }
    }
}
