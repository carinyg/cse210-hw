using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetNumerator(3);
        f1.SetDenominator(4);
        f1.DisplayFraction();

        Fraction f2 = new Fraction(5);
        f2.SetNumerator(7);
        f2.SetDenominator(8);
        f2.DisplayFraction();

        Fraction f3 = new Fraction(9, 10);
        f3.SetNumerator(11);
        f3.SetDenominator(12);
        f3.DisplayFraction();
        
    }
}