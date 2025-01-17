public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.Write("Date: ");
        Console.Write(_date);
        Console.Write(" - Prompt: ");
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

}