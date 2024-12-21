class Usuario{
    private string _nombre;
    private string _apellido;
    private string _correo;
    private string _password;
    private string _telefono;

    public Usuario(string nombre, string apellido, string correo, string password, string telefono){
        _nombre = nombre;
        _apellido = apellido;
        _correo = correo;
        _password = password;
        _telefono = telefono;
    }

    public Usuario(){
        _nombre = "";
        _apellido = "";
        _correo = "";
        _password = "";
        _telefono = "";
    }

    public string Nombre{
        get => _nombre;
        set => _nombre = value;
    }

    public string Apellido{
        get => _apellido;
        set => _apellido = value;
    }

    public string Correo{
        get => _correo;
        set => _correo = value;
    }

    public string Password{
        get => _password;
        set => _password = value;
    }

    public string Telefono{
        get => _telefono;
        set => _telefono = value;
    }

    static  void Bienvenida(){
        Console.WriteLine("Please enter your details for registration");
    }
    public void Registrar(Registro registro){
        Console.Clear();
        Bienvenida();
        Console.Write("Nombre: ");
        Nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        Apellido = Console.ReadLine();
        Console.Write("Correo: ");
        Correo = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();
        Console.Write("Telefono: ");
        Telefono = Console.ReadLine();

        registro.AddRegistro(this);

    }


        
}

