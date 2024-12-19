using System;

class Program
{
    static void Main(string[] args)
    {

        // ola mundo
        Console.WriteLine("Hola Mundo!");

        // invocando precio
        Precio precio = new Precio(1000);

        // incocando nombre de la clase
        Console.WriteLine($"He invocado a osvaldo {precio.Precio}");


    }

    
}

