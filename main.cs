using System;

class Program {
  // number of centimeters in an inch
  const double CentimetersPerInch = 2.54;
  public static void Main (string[] args) {
    //input
    double inches = 5;
    double y = 50;
    double z = -15;
    double a = 15994;
    //conversion
    double centimeters = inches * 2.54;
    //result
    Console.WriteLine($"{inches} inches is {inches * CentimetersPerInch} centimeters");
    Console.WriteLine($"{y} inches is {y * CentimetersPerInch} centimeters");
    Console.WriteLine($"{z} inches is {z * CentimetersPerInch} centimeters");
    Console.WriteLine($"{a} inches is {a * CentimetersPerInch} centimeters");
  }
}
