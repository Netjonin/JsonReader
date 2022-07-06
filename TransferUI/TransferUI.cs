

using TransferCalculations;

namespace UI
{
    public static class TransferUI
    {
        public static void Result()
        {
            Console.WriteLine();
            Console.WriteLine("Good day! Kindly input the amount you wish to transfer between 1 to 999999999...");
            var output = Console.ReadLine();
            var input = Convert.ToInt32(output);
            var transferAmount = Charges.RecommendedAmount(input);  
            var charge = Charges.ChargesToPay(input);
            var debitAmount = Charges.DebitAmount(transferAmount, charge);
            Console.WriteLine("Find below a table of the recommended transfer amount and the corresponding charge");
            Console.WriteLine();
            Console.WriteLine( "|---------------|------------------|------------|---------------|");
            Console.WriteLine( "|     Amount    | Transfer Amount  |   Charge   |  Debit Amount |");
            Console.WriteLine( "|---------------|------------------|------------|---------------|");
            Console.WriteLine($"|     {input}   | {transferAmount} |   {charge} |  {debitAmount}|");
            Console.WriteLine( "|---------------|------------------|------------|---------------|");        
        }
    }
}