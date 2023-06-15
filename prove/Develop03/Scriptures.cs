public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference);
        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write("***** ");
            else
                Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
}

public class Reference
{
    private string reference;

    public Reference(string reference)
    {
        this.reference = reference;
    }

    public override string ToString()
    {
        return reference;
    }
}

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public bool IsHidden
    {
        get { return isHidden; }
    }

    public void Hide()
    {
        isHidden = true;
    }

    public override string ToString()
    {
        return text;
    }
}