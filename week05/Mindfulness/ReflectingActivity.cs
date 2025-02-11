public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you felt a strong sense of accomplishment.",
        "Think of a time when you overcame a fear.",
        "Think of a time when you showed great courage.",
        "Think of a time when you showed great compassion.",
        "Think of a time when you showed great patience.",
        "Think of a time when you used the scriptures to find an answer to a problem.",
        "Think of a time when you felt the Spirit strongly.",
        "Think of a time when you felt the love of God in your life.",
        "Think of a time when you felt the love of Jesus Christ in your life.",
        "Think of a time when you felt a prompting and acted on it.",
        "Think of a time when you felt the power of prayer in your life.",
        "Think of a time when you felt the power of the Atonement in your life.",
        "Think of a time when watching a conference talk helped you.",
        "Think of a time when you felt the power of the priesthood in your life.",
        "Think of a time when attending the temple helped you.",
        "Think of a time when you felt personal growth after stepping out of your comfort zone.",
        "Think of a time when you witnessed a miracle.",
        "Think of a time when you followed the example of Jesus Christ.",
        "Think of a time when you had to forgive someone.",
        "Think of a time when you felt the power of forgiveness in your life.",
        "Think of a time when you felt the power of repentance in your life.",
        "Think of a time when your example helped someone else."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "Was there a different experience that came to mind when you were thinking about this one?",
        "What was the most difficult part of this experience?",
        "What was the most rewarding part of this experience?",
        "What was the most surprising part of this experience?",
        "What was the most important part of this experience?",
        "What was the most memorable part of this experience?",
        "What was the most challenging part of this experience?",
        "Was there something you would do differently if you could do it again?",
        "Was there something you would do the same if you could do it again?",
        "Was there something you would do more of if you could do it again?",
        "Was there something you would do less of if you could do it again?",
        "Was there something you would do sooner if you could do it again?",
        "Was there something you would do later if you could do it again?",
        "Is there any part of this experience that you would like to share with someone else?",
        "Is there any part of this experience that you would like to keep to yourself?",
        "Is there any part of this experience that you would like to write down?",
        "Is there any part of this experience that you would like to remember?",
        "Is there any part of this experience that you would like to forget?",
        "Is there any part of this experience that you would like to repeat?",
        "Is there any part of this experience that you would like to avoid?",
        "Is there any part of this experience that you would like to improve?",
        "Is there any part of this experience that you would like to change?",
        "Is there any part of this experience that you would like to understand better?",
        "Is there anything you wish you would have know before you started?",
        "Do you feel prompted to do something as a result of this experience?",
        "Is there someone you would like to thank for helping you with this experience?",
        "Is there someone you are grateful for as a result of this experience?",
        "Are you thinking of someone you would like to reach out to while you're thinking about this experience?",
        "Are you thinking of someone you would like to help while you're thinking about this experience?",
        "Are you thinking of someone you would like to forgive while you're thinking about this experience?",
        "Are you thinking of someone you would like to apologize to while you're thinking about this experience?",
        "Are you thinking of someone you would like to pray for while you're thinking about this experience?",
        "Are you thinking of someone you would like to serve while you're thinking about this experience?",
        "What motivated you to do this?",
        "What inspired you to do this?",
        "What encouraged you to do this?",
        "What helped you to do this?",
        "What support did you receive while you were doing this?",
        "What did you learn about others through this experience?",
        "What did you learn about God through this experience?",
        "What did you learn about Jesus Christ through this experience?",
        "What did you learn about the Holy Ghost through this experience?",
        "What did you learn about yourself through this experience?",
        "What did you learn about your relationships through this experience?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run(int duration)
    {
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine("");
            Thread.Sleep(1000);
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the follwing prompt:");
        Console.WriteLine($"---{GetRandomPrompt()} ---");
        Console.WriteLine("");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}