public class ListingActivity : Activity
{
    private int _count;

    private List<string> _userResponses = new List<string>();
    private List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths that you have?",
        "Who are the people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What things bring you comfort?",
        "What things bring you joy?",
        "What things bring you peace?",
        "Who are the people throughout your life that you love?",
        "Where are your favorite places you have been?",
        "Who are the people that you have learned from?",
        "What are the things that you are grateful for?",
        "What are your favorite scriptures?",
        "What are your favorite hymns?",
        "What are your favorite conference talks?",
        "What do you do to show love to others?",
        "What do you do to show love to God?",
        "Who has shown love to you?",
        "Who has helped you become who you are?",
        "Which historical figures do you admire?",
        "What are your favorite books?",
        "What are your favorite movies?",
        "What are your favorite songs?",
        "What are your favorite foods?",
        "Who are your favorite artists?",
        "What are your favorite quotes?",
        "What are your favorite games?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run(int duration)
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _userResponses.Add(response);
            _count++;
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} responses.");
        Console.WriteLine("");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}