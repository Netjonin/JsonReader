using Newtonsoft.Json;

namespace Entity
{
    public class Fees
    {
        [JsonProperty("fees")]
        public List<Fee>? AllFees { get; set; }
    }
}