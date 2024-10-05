public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text;
    }

    public string GetOriginalText()
    {
        return _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}