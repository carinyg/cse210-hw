public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
    }

    public void Run(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Thread.Sleep(500);
            Console.Write("     ()     ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b  \b\b\b\b\b\b\b");
            Console.Write("    (  )    ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b    \b\b\b\b\b\b\b\b");
            Console.Write("   (    )   ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b      \b\b\b\b\b\b\b\b\b");
            Console.Write("  (      )  ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b\b        \b\b\b\b\b\b\b\b\b\b");
            Console.Write(" (        ) ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("(          )");
            Thread.Sleep(500);
            Console.WriteLine("\b\b\b\b\b\b\b\b\b\b\b\b            \b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out...");
            Thread.Sleep(500);
            Console.Write("(          )");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b            \b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write(" (        ) ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("  (      )  ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b\b        \b\b\b\b\b\b\b\b\b\b");
            Console.Write("   (    )   ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b      \b\b\b\b\b\b\b\b\b");
            Console.Write("    (  )    ");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b    \b\b\b\b\b\b\b\b");
            Console.Write("     ()     ");
            Thread.Sleep(500);
            Console.WriteLine("\b\b\b\b\b\b\b  \b\b\b\b\b\b\b");
            Console.WriteLine("");
        }
    }
}