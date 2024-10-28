using System;
using System.Collections.Generic;

public class Root
{
    public List<Book> Books { get; set; }
    public string LastModified { get; set; }
    public string LdsSlug { get; set; }
    public string TheEnd { get; set; }
    public string Title { get; set; }
    public int Version { get; set; }
}

public class Book
{
    public string BookName { get; set; } // Map "book"
    public List<Chapter> Chapters { get; set; }
    public string FullTitle { get; set; }
    public string LdsSlug { get; set; }
    
}

public class Chapter
{
    public int ChapterNumber { get; set; } // Map "chapter"
    public string Reference { get; set; }
    public List<Verse> Verses { get; set; }
}

public class Verse
{
    public string Reference { get; set; }
    public string Text { get; set; }
    public int VerseNumber { get; set; } // Map "verse"
}
