public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry (string prompText, string entryText)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = prompText;
        _entryText = entryText;
    }

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