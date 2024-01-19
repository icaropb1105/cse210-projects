public class Entry
{
    public DateTime _date { get; private set; }
    public string _promptText { get; private set; }
    public string _entryText { get; private set; }


    public void SetDate(DateTime date)
    {
        _date = date;
    }


    public Entry(string prompt, string entry)
    {
        _date = DateTime.Now;
        _promptText = prompt;
        _entryText = entry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Prompt: {_promptText} | Entry: {_entryText}");
    }

}   