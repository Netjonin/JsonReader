using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fee
    {
        [JsonProperty("minAmount")]
        public  int MinAmount { get; set; }

        [JsonProperty("maxAmount")]
        public int MaxAmount { get; set; }

        [JsonProperty("feeAmount")]
        public int FeeAmount { get; set; }
    }
}
