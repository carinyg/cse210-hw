using System.Reflection.Metadata.Ecma335;
using System.IO;

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }

    }

    public static List<Entry> LoadFromFile(string file)
    {
        Console.WriteLine("Loading from file...");
        List<Entry> entry = new List<Entry>();

        string fileName = file;

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
           string[] parts = line.Split("~|~");
              Entry newEntry = new()
              {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
              };
                entry.Add(newEntry);
        }

        return entry;

    }

}
