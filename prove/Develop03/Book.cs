using System.Text.Json;
using System.IO;

using System;
using System.Collections.Generic;

public class Book
{
    public string Name { get; set; }
    public List<Chapter> Chapters { get; set; }

    //los metodos de la clase Book
    public static Book LoadFromFile(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Book>(jsonString);
             //JsonSerializer.Deserialize<List<Book>>(jsonString);
    }

}


public class Chapter
{
    public int Number { get; set; }
    public List<Verse> Verses { get; set; }
}

public class Verse
{
    public int Number { get; set; }
    public string Text { get; set; }
}
