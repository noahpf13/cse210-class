using System.Net;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Methods
    public void WriteEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        string prompt = newPrompt.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry.SetEntry(prompt, response);

        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
    }
    public void SaveJournal()
    {
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.ToFileString());
            }
        }
        Console.WriteLine("Journal saved.");
        Console.WriteLine("Saving to: " + Path.GetFullPath(filename));
    }
    public void LoadJournal()
    {
        string filename = "journal.txt";

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = Entry.FromFileString(line);
            _entries.Add(entry);
        }
        
        Console.WriteLine("Journal loaded from journal.txt.");


    }
    
    
    
}