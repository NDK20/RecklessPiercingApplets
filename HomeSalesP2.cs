using System;

namespace HomeSalesP2
{
    class Program
    {
        static void Main()
        {
            //define arrays to store salesperson names, initials, and sales totals
            string[] salespersonNames = {"Danielle", "Edward", "Francis"};
            char[] allowedInitials = {'D', 'E', 'F'};
            double[] salesTotals = new double[allowedInitials.Length];

            char initial;
            while (true)
            {
                Console.WriteLine("Enter salesperson initial (D, E, or F) or Z to end: ");
                initial = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (initial == 'Z')
                break;
                //check if initial is valid 
                int index = Array.IndexOf(allowedInitials, initial);
                if (index == -1)
                {
                    Console.WriteLine("Invalid initial. Please try again.");
                    continue;
                }

                Console.WriteLine("Enter the amount of sale: ");
                if (double.TryParse(Console.ReadLine(), out double saleAmount) && saleAmount > 0)
                {
                    salesTotals[index] += saleAmount;
                }
                else
                {
                    Console.WriteLine("Invalid sale amount. Please try again.");
                }
            }
            //calc grand total 
            double grandTotal = 0;
            double highestSales = 0;
            string highestSalesperson = "";

            Console.WriteLine("Sales totals by salesperson:");
            for (int i = 0; i < salespersonNames.Length; i++)
            {
                Console.WriteLine($"{salespersonNames[i]}: ${salesTotals[i]:0.00}");
                grandTotal += salesTotals[i];

                if (salesTotals[i] > highestSales)
                {
                    highestSales = salesTotals[i];
                    highestSalesperson = salespersonNames[i];
                }
            }
            //display results
            Console.WriteLine($"Grand total: ${grandTotal:0.00}");
            Console.WriteLine($"Highest sale: {highestSalesperson}");
        }
    }
}
