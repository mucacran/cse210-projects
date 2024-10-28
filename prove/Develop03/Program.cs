using System;
using System.Net.Http.Json;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {

 // Ruta del archivo JSON
        string jsonPath = "old-testament.json";

        // Leer el archivo JSON
        string jsonContent = File.ReadAllText(jsonPath);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        //desearealizar la deserialización de un objeto JSON a un objeto C#.
        // Deserializar el archivo JSON
        Root root = JsonSerializer.Deserialize<Root>(jsonContent);

        foreach (var book in root.books)
        {
            Console.WriteLine(book.book);
 /*         Console.WriteLine(book.full_title);
            Console.WriteLine(book.lds_slug);

            foreach (var chapter in book.chapters)
            {
                Console.WriteLine(chapter.chapter);
                Console.WriteLine(chapter.reference);

                foreach (var verse in chapter.verses)
                {
                    Console.WriteLine(verse.reference);
                    Console.WriteLine(verse.text);
                    Console.WriteLine(verse.verse);
                }
            }*/
        }




        



        // Crear la referencia y escritura
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");



/*
        while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("All words are hidden. Goodbye!");
                break;
            }
        }
        */
    }
}
