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

        // Deserializar el archivo JSON
        Root root = JsonSerializer.Deserialize<Root>(jsonContent);

        if (root == null)
        {
            Console.WriteLine("Error: La deserialización del archivo JSON falló.");
            return;
        }

        if (root.GetBooks() == null || root.GetBooks().Count == 0)
        {
            Console.WriteLine("Error: La lista de libros está vacía o no se inicializó correctamente.");
            return;
        }

        // Crear una instancia de Random
        Random random = new Random();

        // Obtener un índice aleatorio
        int randomIndex = random.Next(root.GetBooks().Count);

        // Obtener el nombre del libro aleatorio
        string randomBookName = root.GetBooks()[randomIndex].GetBook();

        if (root.GetBooks()[randomIndex].GetChapters() == null || root.GetBooks()[randomIndex].GetChapters().Count == 0)
        {
            Console.WriteLine("Error: La lista de capítulos está vacía o no se inicializó correctamente.");
            return;
        }

        var prueba = root.GetBooks()[randomIndex].GetChapters()[0].GetVerses()[0].GetText();

        int randomIndexChapter = random.Next(root.GetBooks()[randomIndex].GetChapters().Count);
        int randomIndexVerse = random.Next(root.GetBooks()[randomIndex].GetChapters()[randomIndexChapter].GetVerses().Count);

        // "text" del versículo aleatorio
        string randomVerseText = root.GetBooks()[randomIndex].GetChapters()[randomIndexChapter].GetVerses()[randomIndexVerse].GetText();

        // Crear la referencia y escritura
        Reference reference = new Reference(randomBookName, randomIndexChapter + 1, randomIndexVerse + 1);
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
