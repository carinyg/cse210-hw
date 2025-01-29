public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string Reference, string text)
    {
        _reference = new Reference(Reference);
        
        string[] text = scriptureText.Split(' ');
        foreach (string word in scriptureWords)
        {
            Word w = new Word(word);
        }

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}