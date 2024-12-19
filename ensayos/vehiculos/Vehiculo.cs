abstract class Vehiculo
{

    // declarara el nombre del objeto
    private string _nombre;

    // metodo para retornar el nombre del objeto
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    // metodo para imprimir por pantalla el nombre del metodo
    public string ImprimirNombre()
    {
        return _nombre;
    }
   
    abstract public void CalcularImpuesto();

    abstract public void MostrarInformacion();
    
}