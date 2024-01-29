using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3,4);
        Fraction fraction3 = new Fraction(1,3);

        string fractionString = fraction.GetFractionString();
        double quotient = fraction.GetDecimalValue();

        Console.WriteLine(fractionString);
        Console.WriteLine(quotient);

        fractionString = fraction1.GetFractionString();
        quotient = fraction1.GetDecimalValue();

        Console.WriteLine(fractionString);
        Console.WriteLine(quotient);

        fractionString = fraction2.GetFractionString();
        quotient = fraction2.GetDecimalValue();

        Console.WriteLine(fractionString);
        Console.WriteLine(quotient);

        fractionString = fraction3.GetFractionString();
        quotient = fraction3.GetDecimalValue();

        Console.WriteLine(fractionString);
        Console.WriteLine(quotient);

    }
}