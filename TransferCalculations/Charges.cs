using Data;


namespace TransferCalculations
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

        public static int RecommendedAmount(int fund)
        {
            int advisedAmount = 0;
            foreach (var fee in JsonLoader.LoadJson()?.AllFees!)
            {
                if (fund >= fee.MinAmount && fund <= fee.MaxAmount)
                    advisedAmount = fund - fee.FeeAmount;
            }
            return advisedAmount;
        }

        public static int DebitAmount(int transferAmount, int charge)
        {
            return charge + transferAmount;
        }
    }
}
