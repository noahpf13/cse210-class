public class Entry
{
    // Variables
    private DateTime _date;
    private string _prompt;
    private string _response;

    public void SetEntry(string prompt, string response)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _response = response;
    }
    public void SetEntryFromFile(DateTime date, string prompt, string response)
    {
    _date = date;
    _prompt = prompt;
    _response = response;
    }

    // Methods
    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToString("MM/dd/yyyy")} - {_prompt}");
        Console.WriteLine($"{_response}");
    }
    public string ToFileString()
    {
        return $"{_date.ToString("MM/dd/yyyy")}|{_prompt}|{_response}";
    }
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|");

        Entry entry = new Entry();
        entry.SetEntryFromFile(DateTime.Parse(parts[0]), parts[1], parts[2]);

        return entry;
    }

}