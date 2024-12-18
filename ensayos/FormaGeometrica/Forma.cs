abstract class Forma{

    private string forma;

    public Forma(){
        forma = "FORMA";
    }

    public void Mostrar(){
        Console.WriteLine($"este es un metodo de la clase Forma: {forma}");
    }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    
}