class Yoga: Clases{
    public Yoga(string nombre): base(nombre){
        nombre = "Yoga";
    }

    public override void Clasede()
    {
        Console.WriteLine($"Clase: {GetNombreClass()}");
    }
}