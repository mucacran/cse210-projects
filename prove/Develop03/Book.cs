using System;
using System.Collections.Generic;

public class Root
{
    public List<Book> books { get; set; }
    public string last_modified { get; set; }
    public string lds_slug { get; set; }
    public string the_end { get; set; }
    public string title { get; set; }
    public int version { get; set; }

/*
    public Root()
    {
        books = new List<Book>();
    }*/
}

public class Book
{
    public string book { get; set; } // Map "book"
    public List<Chapter> chapters { get; set; }
    public string full_title { get; set; }
    public string lds_slug { get; set; }
}

public class Chapter
{
    public int chapter { get; set; } // Map "chapter"
    public string reference { get; set; }
    public List<Verse> verses { get; set; }
}

public class Verse
{
    public string reference { get; set; }
    public string text { get; set; }
    public int verse { get; set; } // Map "verse"
}


//uno de mis errores es que tenia que definir el nombre igual como en las propiedades de json con el mismo nombre 