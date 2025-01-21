public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
       _numerator = 1;
       _denominator = 1; 
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void DisplayFraction()
    {
        System.Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }   
}