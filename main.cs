using System;
  class Program {
  public static void Main (string[] args) {
    //constants for rates
    const double BASE_RATE = 200;
    const double HOURLY_RATE = 150;
    const double MILES_RATE = 2;
    //prompt for input
    //number of hours worked
    Console.WriteLine("Enter the number of hours worked: ");
    string hours = Console.ReadLine();
    //number of miles driven
    Console.WriteLine("Enter the number of miles driven: ");
    string miles = Console.ReadLine();
    //parse input to double
    if (double.TryParse(hours, out double hoursworked) && double.TryParse(miles, out double milesdriven)) {
    //calc total
    double total = BASE_RATE + (HOURLY_RATE * hoursworked) + (MILES_RATE * milesdriven);
    //output result
    Console.WriteLine("The total cost of the trip is: ${0}", total);
    } else {
      //invalid input}  
      Console.WriteLine("Invalid input. Please enter a number.");
    }
  }
}