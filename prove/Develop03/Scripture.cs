using System;

public class Scripture
{
    private string _text;

    public Scripture()
    {
        _text = "";
    }
    public Scripture(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }
    public void HideWords(Word word)
    {
        Random randWord = new Random();
        var textList = _text.Split(" ");
        int randNum = randWord.Next(0,textList.Length);
        _text = "";

        
        for (int i=0; i<textList.Length; i++)
        {
            word.SetWord(textList[i]);
            if(i == randNum)
            {
                textList[i] = word.Hide();
            }
            _text = $"{_text}{textList[i]} ";
        }
    }

}