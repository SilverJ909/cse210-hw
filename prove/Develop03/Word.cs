using System;

public class Word
{
    private string _word;

    public Word()
    {
        _word = "";
    } 
    public Word(string word)
    {
        _word = word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
    public string Hide()
    {
        int wordLength = _word.Length;
        _word = "";
        for (int i=0;i<wordLength;i++)
        {
            _word = _word+"_";
        }
        return _word;
    }
    public string GetRenderedText()
    {
        return _word;
    }

}