using System;

namespace HomeSales
{
    class Program
    {
        static void Main()
        {
            decimal salesD = 0, salesE = 0, salesF = 0;
            while (true) 
            {
                Console.Write("Enter salesperson initial (D, E, or F) or Z to end: ");
                char salesperson = char.ToUpper(Console.ReadLine()[0]);
                if (salesperson == 'Z')
                    break;
                if (salesperson != 'D' && salesperson != 'E' && salesperson != 'F')
                {
                    Console.WriteLine("Error, invalid salesperson selected, please try again.");
                    continue;
                }
                Console.Write("Enter amount of sale: ");
                decimal saleAmount = decimal.Parse(Console.ReadLine());
                switch (salesperson)
                {
                    case 'D':
                        salesD += saleAmount;
                        break;
                    case 'E':
                        salesE += saleAmount;
                        break;
                    case 'F':
                        salesF += saleAmount;
                        break;
                }
            }
            decimal grandTotal = salesD + salesE + salesF;
            string highestSalesPerson = "";
            decimal highestSales = 0;
            
            if (salesD >= salesE && salesD >= salesF) { highestSalesPerson = "D"; highestSales = salesD; }
            if (salesE >= salesD && salesE >= salesF) { highestSalesPerson = "E"; highestSales = salesE; }
            if (salesF >= salesD && salesF >= salesE) { highestSalesPerson = "F"; highestSales = salesF; }
            Console.WriteLine("Total sales for D: {0:C}", salesD);
            Console.WriteLine("Total sales for E: {0:C}", salesE);
            Console.WriteLine("Total sales for F: {0:C}", salesF);
            Console.WriteLine("Grand total: {0:C}", grandTotal);
            Console.WriteLine("Highest total: {0}", highestSalesPerson);
         }
    }
}