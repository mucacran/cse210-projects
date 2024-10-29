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

        // Crear una instancia de Random
        Random random = new Random();

        // Obtener un índice aleatorio
        int randomIndex = random.Next(root.books.Count);

        // Obtener el nombre del libro aleatorio
        string randomBookName = root.books[randomIndex].book;

        var prueba = root.books[randomIndex].chapters[0].verses[0].text;

        int randomIndexChapter = random.Next(root.books[randomIndex].chapters.Count);
        int randomIndexVerse = random.Next(root.books[randomIndex].chapters[randomIndexChapter].verses.Count);
        // "text" del versículo aleatorio
        string randomVerseText = root.books[randomIndex].chapters[randomIndexChapter].verses[randomIndexVerse].text;

        //numero de capitulos de un libro randomBookName
        Console.WriteLine("Numero de capitulos: " + root.books[randomIndex].chapters.Count);

        //numero total de versiculos de el capitulo randomIndexChapter de el libro randomBookName
        Console.WriteLine("Numero de versiculos del capitulo " + randomIndexChapter + " del libro de " + randomBookName + ": " + root.books[randomIndex].chapters[randomIndexChapter].verses.Count);       
        

        Console.WriteLine("Libro prueb: " + prueba);

        Console.WriteLine("Libro aleatorio: " + randomBookName);
        
        //imprimir por pantalla los capitulos del libro root.books[randomIndex].book



        /*foreach (var book in root.books)
        {
            Console.WriteLine(book.book);
            Console.WriteLine(book.full_title);
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
            }
        }*/

        //elegir de forma aleatoria un nombre de libro book.book
        
        // Crear la referencia y escritura
        Reference reference = new Reference(randomBookName, randomIndexChapter+1, randomIndexVerse+1);
        Scripture scripture = new Scripture(reference, randomVerseText);




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
                Console.WriteLine("All words are hidden. Goodbye Sergio!");
                break;
            }
        }
        
    }
}
