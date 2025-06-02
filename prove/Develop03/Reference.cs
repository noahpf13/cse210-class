public class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;
    private int _verse;
    private bool _hasrange;
    
    // Multiple Verse
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
        _hasrange = true;
    }
    // Single Verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _hasrange = false;
    }

    public string DisplayText()
    {
        if (_hasrange)
        {
            return $"{_book} {_chapter}:{_startverse}-{_endverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        


    }
}