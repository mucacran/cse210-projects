class Crosfit : Clases
{
    public Crosfit(string nombre) : base(nombre) {
        nombre = "Crosfit";
    }

    public override void Clasede()
    {
        Console.WriteLine($"Clase: {GetNombreClass()}");
    }
}
