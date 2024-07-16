using System;

class Program {
  // number of centimeters in an inch
  const double CentimetersPerInch = 2.54;
  public static void Main (string[] args) {

    //prompt for input 
    Console.WriteLine("Enter a number of inches: ");

    //read input and convert to double 
    if (double.TryParse(Console.ReadLine(), out double inches)) {
    
    //calc centimeters
    double centimeters = inches * CentimetersPerInch;
    
    //output result
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);

    //invalid input
      } else {
      Console.WriteLine("Invalid input. Please enter a number.");
    }
  }
}