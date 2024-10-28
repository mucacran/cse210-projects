using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;

public class Root
{
    public List<Book> Books { get; set; }
    public string LastModified { get; set; }
    public string LdsSlug { get; set; }
    public string TheEnd { get; set; }
    public string Title { get; set; }
    public int Version { get; set; }



    //contructor de la clase Root
    public Root(string lastModified, string ldsSlug, string theEnd, string title, int version)
    {
        LastModified = lastModified;
        LdsSlug = ldsSlug;
        TheEnd = theEnd;
        Title = title;
        Version = version;
        Books = new List<Book>();
    }

    //constructor de la clase Root
    public Root(List<Book> books, string lastModified, string ldsSlug, string theEnd, string title, int version)
    {
        Books = books;
        LastModified = lastModified;
        LdsSlug = ldsSlug;
        TheEnd = theEnd;
        Title = title;
        Version = version;
    }

    //constructor de la clase Root
    public Root()
    {
        Books = new List<Book>();
        LastModified = "";
        LdsSlug = "";
        TheEnd = "";
        Title = "";
        Version = 0;
    }

    //metodo para List<Book> Books
    public void AddBooks(string filePath)
    {
        string json = File.ReadAllText(filePath);
        Root root = JsonSerializer.Deserialize<Root>(json);
        //Books = root.Books;
        foreach (var book in root.Books)
        {
            AddBook(book.BookName);
        }

        ////////////////////////////////////////////

    }

    //metodo para ingresar los nombres los libros
    public void AddBook(string bookName)
    {
        Books.Add(new Book { BookName = bookName });
    }

    //metodo para ingresar el contenido de LastModified
    public void AddLastModified(string lastModified)
    {
        LastModified = lastModified;
    }

    //metodo para ingresar el contenido de LdsSlug
    public void AddLdsSlug(string ldsSlug)
    {
        LdsSlug = ldsSlug;
    }

    //metodo para ingresar el contenido de TheEnd
    public void AddTheEnd(string theEnd)
    {
        TheEnd = theEnd;
    }

    //metodo para ingresar el contenido de Title
    public void AddTitle(string title)
    {
        Title = title;
    }

    //metodo para ingresar el contenido de Version
    public void AddVersion(int version)
    {
        Version = version;
    }

}

public class Book
{
    public string BookName { get; set; } // Map "book"
    public List<Chapter> Chapters { get; set; }
    public string FullTitle { get; set; }
    public string LdsSlug { get; set; }

    //metodo para ingresar los nombres los libros
    
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
