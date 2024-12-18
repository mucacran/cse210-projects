using System;


class Program
{
    static void Main(string[] args){
        //Forma forma = new Forma();

        //forma.Mostrar();

        Console.WriteLine("Hola mundo");

        Triangulo t = new Triangulo(10, 5);

        t.Mostrar();

        Forma f = new Triangulo(20, 5);


        Console.WriteLine($"esta es el area de un triangulo: {t.CalcularArea()}");

        Console.WriteLine($"esta es el area de un triangulo: {t.CalcularPerimetro()}");

        Console.WriteLine($"esta es el area de un Forma: {f.CalcularPerimetro()}");

        Circulo c = new Circulo(5);

        Console.WriteLine($"esta es el area de un Circulo: {c.Perimetro()}");
    }
}




