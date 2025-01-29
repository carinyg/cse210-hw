using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("James", 1, 5, 6);

        string scriptureText = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";
        Scripture s1 = new Scripture(r1, scriptureText);

        


        Console.Write(r1.GetDisplayText());
    }
}