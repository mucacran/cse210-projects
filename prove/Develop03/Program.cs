﻿using System;

class Program
{
    static void Main(string[] args)
    {
        
        string filePath = "old-testament.json";

        // Llama al método de carga de nombres desde la clase Book
        Book.LoadBookNames(filePath);


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
