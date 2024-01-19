public class Journal
{
    public List<Entry> _entries { get; private set; }
    
     public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
    {
        foreach (var entry in _entries)
        {
            writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }

    Console.WriteLine($"Journal saved to {file}");
    }

        public void LoadFromFile(string file)
{
    _entries.Clear();

    using (StreamReader reader = new StreamReader(file))
    {
        while (!reader.EndOfStream)
        {
            string[] parts = reader.ReadLine()?.Split(',');

            if (parts?.Length == 3)
            {
                if (DateTime.TryParse(parts[0], out DateTime date))
                {
                    Entry entry = new Entry(parts[1], parts[2]);
                    entry.SetDate(date);
                    _entries.Add(entry);
                }
            }
        }
    }

    Console.WriteLine($"Journal loaded from {file}");
}


}