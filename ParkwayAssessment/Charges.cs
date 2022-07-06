using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkwayAssessment
{
    public static class Charges
    {
        public static int ChargesToPay(int fund)
        {
            int charge = 0;
            foreach(var fee in JsonLoader.LoadJson()?.AllFees!)
            {
                if (fund >= fee.MinAmount && fund <= fee.MaxAmount)
                    charge = fee.FeeAmount;
            }
            return charge;
        }
    }
}
