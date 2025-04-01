public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd; // Nullable for single verses

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = null;
    }

    // Constructor for verse range
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    // Returns formatted reference (e.g., "John 3:16" or "Proverbs 3:5-6")
    public string GetDisplayText()
    {
        return _verseEnd == null 
            ? $"{_book} {_chapter}:{_verseStart}" 
            : $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}