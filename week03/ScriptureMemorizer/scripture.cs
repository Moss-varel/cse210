public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Hide a few random words
    public void HideRandomWords(int count = 3)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden() => _words.All(word => word.IsHidden());

    // Display scripture with reference
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {wordsText}";
    }
}