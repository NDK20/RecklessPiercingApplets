using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter message to be encrypted:");
    string message = Console.ReadLine();
    if(message.Length <= 140) {
      Console.WriteLine("Posted");
    } else {
      Console.WriteLine("Rejected");
    }
  }
}