public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Constructor to load a scripture with a saved hidden state
    public Scripture(string reference, string text, string hiddenState)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordTexts = text.Split(' ');
        string[] hiddenStates = hiddenState.Split(' ');

        for (int i = 0; i < wordTexts.Length; i++)
        {
            Word word = new Word(wordTexts[i]);
            if (hiddenStates[i] == "1") word.Hide();
            _words.Add(word);
        }
    }

    // Display the scripture with hidden words
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_reference}:");
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    // Hide random words
    public void HideRandomWords()
    {
        Random rand = new Random();
        int index = rand.Next(_words.Count);
        _words[index].Hide();
    }

    // Save the current state of the scripture (word state: hidden or not)
    public string GetScriptureState()
    {
        string text = "";
        string hiddenState = "";

        foreach (var word in _words)
        {
            text += word.GetOriginalText() + " ";
            hiddenState += word.IsHidden() ? "1 " : "0 ";
        }

        return $"{_reference};{text.Trim()}\n{hiddenState.Trim()}";
    }
}