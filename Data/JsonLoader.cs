using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class JsonLoader
    {
        public static Fees? LoadJson()
        {
            var feespath = @"./fees.config.json";
            var feesData = File.ReadAllText(feespath);
            var fees = JsonConvert.DeserializeObject<Fees>(feesData);
            return fees;
        }
    }
}
