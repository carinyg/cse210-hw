public class Journal
{
    public List<Entry> _entries = [];

    public void AddEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string entryText = Console.ReadLine();
        Entry entry = new()
        {
            _date = DateTime.Now.ToString(),
            _promptText = prompt,
            _entryText = entryText
        };
        _entries.Add(entry);
        Console.WriteLine("");


    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}
