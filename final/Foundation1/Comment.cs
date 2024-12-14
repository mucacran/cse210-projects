using System;

public class Comment
{
    private string _commentAuthor;
    private string _commentText;

    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _commentText = text;
    }

    public string GetAuthor()
    {
        return _commentAuthor;
    }

    public string GetText()
    {
        return _commentText;
    }
}
