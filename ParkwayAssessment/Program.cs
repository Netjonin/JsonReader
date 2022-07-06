// See https://aka.ms/new-console-template for more information
using Data;
using ParkwayAssessment;
Console.Write("Hello!");
Console.WriteLine(" What is your name please?");
var output = Console.ReadLine();
var input = Convert.ToInt32(output);
Console.WriteLine(Charges.RecommendedAmount(input));
//Console.WriteLine(Charges.ChargesToPay(input));



