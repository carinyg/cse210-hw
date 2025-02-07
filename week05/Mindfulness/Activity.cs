public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity()
    {

    }

    public int DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session to run? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000);
        return _duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        
    }
}