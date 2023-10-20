using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public Reference()
    {
        _book = "";
        _chapter = 0;
        _verse = "";
    }
    public Reference(string book,int chapter,string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book,int chapter,string startVerse,string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{startVerse}-{endVerse}";
    }


    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(string verse)
    {
        _verse = verse;
    }
    public void SetVerse(string startVerse,string endVerse)
    {
        _verse = $"{startVerse}-{endVerse}";
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public string GetVerse()
    {
        return _verse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}