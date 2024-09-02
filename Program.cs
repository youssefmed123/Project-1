using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washing_machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name of the window 
            Console.Title = "Islam's Carpet Cleaning Service";

			//Function for user name
			
			Console.Write("Enter your name : ");

            Console.ForegroundColor= ConsoleColor.White;
            string userName = Console.ReadLine();

            Console.WriteLine("Nice to meet you " + userName);
      

            //Function for charges
            Console.WriteLine(" This is Islam's Carpet Cleaning Service");
            Console.WriteLine(" Here's our Charges:");
            Console.WriteLine("  $25 per small carpet");
            Console.WriteLine("  $35 per large carpet");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");

            //Function for the number of Carpets
            Console.WriteLine("How many small carpits ?");


			int smallCarpet = int.Parse(Console.ReadLine());


			Console.WriteLine("How many Large Carpets ?");


            int largeCarpet = int.Parse(Console.ReadLine());

            //Tax and price
            double priceOfsmall = 25;
            double priceOflarge = 35;
            double TaxRate = 0.06;

            //Calculation
            double Totalcost = (priceOfsmall * smallCarpet) + (priceOflarge * largeCarpet) ;
            double Tax = Totalcost * TaxRate;
            double TotalEstimate= Totalcost + Tax;
            //Estimate
            Console.WriteLine("Esimate for carpet washing service");
            Console.WriteLine($"Number of small carpets : {smallCarpet}");
            Console.WriteLine($"Number of large carpets : {largeCarpet}");
            Console.WriteLine($"Price per small carpets : {priceOfsmall}");
            Console.WriteLine($"Price per large carpets : {priceOflarge}");
            Console.WriteLine($"Total Cost: ${Totalcost}");
            Console.WriteLine($"Tax: {TaxRate}");
            Console.WriteLine();
            Console.WriteLine($"Total Estimate: ${TotalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}

