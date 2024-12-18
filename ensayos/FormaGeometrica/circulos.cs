class Circulo : Forma
{
    private double radio;
    private string forma

    public Circulo()
    {
        radio = 0;
        forma = "Circulo";
    }
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }
}
