using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction f1 = new Fraction(); 
        Fraction f2 = new Fraction(5); 
        Fraction f3 = new Fraction(3, 4); 

        
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

       
        f1.SetNumerator(2);
        f1.SetDenominator(3);
        Console.WriteLine($"Updated Fraction 1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        f3.SetDenominator(5);
        Console.WriteLine($"Updated Fraction 3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");
    }
}