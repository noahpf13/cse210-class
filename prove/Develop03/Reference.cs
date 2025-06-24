// Reference.cs
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private int _verse;
    private bool _hasRange;

    // Multiple Verse
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _hasRange = true;
    }

    // Single Verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _hasRange = false;
    }

    public string DisplayText()
    {
        return _hasRange
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_chapter}:{_verse}";
    }
}
