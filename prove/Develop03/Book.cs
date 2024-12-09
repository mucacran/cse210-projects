using System;
using System.Collections.Generic;

public class Root
{
    private List<Book> books;
    private string lastModified;
    private string ldsSlug;
    private string theEnd;
    private string title;
    private int version;

    public List<Book> GetBooks() => books;
    public void SetBooks(List<Book> value) => books = value;

    public string GetLastModified() => lastModified;
    public void SetLastModified(string value) => lastModified = value;

    public string GetLdsSlug() => ldsSlug;
    public void SetLdsSlug(string value) => ldsSlug = value;

    public string GetTheEnd() => theEnd;
    public void SetTheEnd(string value) => theEnd = value;

    public string GetTitle() => title;
    public void SetTitle(string value) => title = value;

    public int GetVersion() => version;
    public void SetVersion(int value) => version = value;

    // Constructor para inicializar desde propiedades deserializadas
    public Root(List<Book> books, string lastModified, string ldsSlug, string theEnd, string title, int version)
    {
        this.books = books;
        this.lastModified = lastModified;
        this.ldsSlug = ldsSlug;
        this.theEnd = theEnd;
        this.title = title;
        this.version = version;
    }
}

public class Book
{
    private string book;
    private List<Chapter> chapters;
    private string fullTitle;
    private string ldsSlug;

    public string GetBook() => book;
    public void SetBook(string value) => book = value;

    public List<Chapter> GetChapters() => chapters;
    public void SetChapters(List<Chapter> value) => chapters = value;

    public string GetFullTitle() => fullTitle;
    public void SetFullTitle(string value) => fullTitle = value;

    public string GetLdsSlug() => ldsSlug;
    public void SetLdsSlug(string value) => ldsSlug = value;

    // Constructor para inicializar desde propiedades deserializadas
    public Book(string book, List<Chapter> chapters, string fullTitle, string ldsSlug)
    {
        this.book = book;
        this.chapters = chapters;
        this.fullTitle = fullTitle;
        this.ldsSlug = ldsSlug;
    }
}

public class Chapter
{
    private int chapter;
    private string reference;
    private List<Verse> verses;

    public int GetChapter() => chapter;
    public void SetChapter(int value) => chapter = value;

    public string GetReference() => reference;
    public void SetReference(string value) => reference = value;

    public List<Verse> GetVerses() => verses;
    public void SetVerses(List<Verse> value) => verses = value;

    // Constructor para inicializar desde propiedades deserializadas
    public Chapter(int chapter, string reference, List<Verse> verses)
    {
        this.chapter = chapter;
        this.reference = reference;
        this.verses = verses;
    }
}

public class Verse
{
    private string reference;
    private string text;
    private int verse;

    public string GetReference() => reference;
    public void SetReference(string value) => reference = value;

    public string GetText() => text;
    public void SetText(string value) => text = value;

    public int GetVerse() => verse;
    public void SetVerse(int value) => verse = value;

    // Constructor para inicializar desde propiedades deserializadas
    public Verse(string reference, string text, int verse)
    {
        this.reference = reference;
        this.text = text;
        this.verse = verse;
    }
}