using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        this._reference = reference;
        _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(x => random.Next()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public void Display()
    {
        Console.Write(_reference.GetReferenceText() + " ");
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }
}
