using System;
namespace Perfect 
{
    class Program 
  {
     static void Main(string[] args) 
    {
        Console.WriteLine("Enter a number to check if it is perfect or not: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (isPerfect(inputNumber))
        {
            Console.WriteLine("Perfect Number");
        } 
        else
        {
            Console.WriteLine("Not a Perfect Number");
        }
    }
    public static bool isPerfect(int n) 
    {
        int sum = 0;
        for(int i = 1; i <= n / 2; i++) 
        {
            if (n % i == 0) 
            {
                sum += i;
            }
        }
    return sum == n;
    }
  }
}
