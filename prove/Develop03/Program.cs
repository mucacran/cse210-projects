﻿using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {

 // Ruta del archivo JSON
        string jsonPath = "cor.json";

        // Leer el archivo JSON
        string jsonContent = File.ReadAllText(jsonPath);

        

        
        Console.WriteLine(jsonContent);


        



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
