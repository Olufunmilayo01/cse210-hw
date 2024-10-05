public class Reference
{
    private string _book;
    private int _chapter;
    private string _verses;

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse.ToString();
    }

    // Constructor for verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{startVerse}-{endVerse}";
    }

    // Method to return the reference as a string
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verses}";
    }
}