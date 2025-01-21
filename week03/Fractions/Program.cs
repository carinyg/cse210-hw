using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.DisplayFraction();

        Fraction f2 = new Fraction(6);
        f2.DisplayFraction();

        Fraction f3 = new Fraction(6, 7);
        f3.DisplayFraction();
    }
}