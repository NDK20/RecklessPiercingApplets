using System;
using System.Collections.Generic;

namespace TemperaturesComparison 
{
    class Program 
    {
        static void Main()
        {
            //assign constants to integar values
            const int numberOfTemperatures = 5;
            const int minTemp = -30;
            const int maxTemp = 130;
            List<int> temperatures = new List <int>();
            //colllect valid temperatures from user
            for (int i = 0; i < numberOfTemperatures; i++)
            {
                int temp;
                Console.WriteLine($"Enter temperature {i + 1}: (between {minTemp} and {maxTemp})");
                //validate input, insure int within valid range
                while (!int.TryParse(Console.ReadLine(), out temp) || temp < minTemp || temp > maxTemp)
                {
                    Console.WriteLine($"Invalid input. Please enter a temperature between {minTemp} and {maxTemp}.");
                }
                temperatures.Add(temp); 
            }
            //check if temperatures are in order
            bool isAscending = true;
            bool isDescending = true;
            //loop through temperatures and check if they are in order
            for (int i = 1; i < numberOfTemperatures; i++)
            {
                if (temperatures[i] <= temperatures[i - 1])
                {
                    isAscending = false;
                }
                if (temperatures[i] >= temperatures[i - 1])
                {
                    isDescending = false;
                }
            }
            //display the order pattern message
            if (isAscending)
            {
                Console.WriteLine("Getting warmer.");
            }
            else if (isDescending)
            {
                Console.WriteLine("Getting cooler.");
            }
            else
            {
                Console.WriteLine("It's a mixed bag.");
            }
            //display the entered temperatures
            Console.WriteLine("5-day Temperature [" + string.Join(", ", temperatures) + "]");
            //calc and display the average temperature
            double averageTemp = 0;
            foreach (var temp in temperatures)
            {
                averageTemp += temp;
            }
            averageTemp /= numberOfTemperatures;
            Console.WriteLine($"Average Temperature: {averageTemp:0.00} degrees");
    
        }
    }
}


