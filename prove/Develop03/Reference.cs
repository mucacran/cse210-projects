using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; // Para escrituras con múltiples versículos

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    public string GetReferenceText()
    {
        if (_endVerse == null)
            return $"{_book} {_chapter}:{_startVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
