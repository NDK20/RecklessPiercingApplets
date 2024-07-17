using System;

class Program {
    public static string Hurricane(double windSpeed) {
        if (windSpeed >= 157) {
            return "Category Five Hurricane"; }
        else if (windSpeed >= 130) {
            return "Category Four Hurricane"; }
        else if (windSpeed >= 111) {
            return "Category Three Hurricane"; }
        else if (windSpeed >= 96) {
            return "Category Two Hurricane"; }
        else if (windSpeed >= 74) {
            return "Category One Hurricane"; }
        else {
            return "Not a Hurricane"; }
    }
    public static void Main(string[] args) {
        try {
            Console.Write("Enter the wind speed (in mph): ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());
            string category = Hurricane(windSpeed);
            Console.WriteLine(category); }
        catch (FormatException) {
            Console.WriteLine("Please enter a valid number for the wind speed.");
        }
    }
}
