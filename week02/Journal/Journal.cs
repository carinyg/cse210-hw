public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Enter your journal entry: ");
        Console.ReadLine();
        string entryText = Console.ReadLine();
        Entry entry = new (prompt, entryText);
        _entries.Add(entry);

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}
