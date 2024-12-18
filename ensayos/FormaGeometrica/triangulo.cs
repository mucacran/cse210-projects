class Triangulo : Forma{
    private string forma;

    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area { get; set; }

    public Triangulo(){
        Base = 0;
        Altura = 0;
        Area = 0;

        forma = "Triangulo";
    }

    public Triangulo(double b, double a){
        Base = b;
        Altura = a;
        Area = (Base * Altura) / 2;
    }

    public override double CalcularArea(){
        return (Base * Altura)/2;
    }

    public override double CalcularPerimetro(){
        return 2 * (Base + Altura);
    }

    pubñic void Mostrar(){
        Console.WriteLine($"este es un metodo de la clase Triangulo: {forma}");
    }
}