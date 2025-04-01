public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide() => _isHidden = true;

    // Show underscores if hidden, else the word
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    // Check if word is already hidden
    public bool IsHidden() => _isHidden;
}