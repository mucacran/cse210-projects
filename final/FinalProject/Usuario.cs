class Usuario{
    private string _nombre;
    private string _apellido;
    private string _correo;
    private string _password;
    private string _telefono;
    //una simple lista de cosas
    private List<string> _usuarios;

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
        _usuarios = new List<string>();
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
        Console.WriteLine("Bienvenido a la plataforma de clases virtuales");
    }
    public void Registrar(){
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

        Usuario user = new Usuario(Nombre, Apellido, Correo, Password, Telefono);

        //_usuarios.Add(this);
 
    }

    public void guardarListaenPropiedad(string _nombre,string _apellido,string _correo,string _password,string _telefono){
        //Guardar la lista de usuarios en una propiedad
        string user = $"{_nombre},{_apellido},{_correo},{_password},{_telefono}";

        _usuarios.Add(user);
    }


    // Guardar usuarios en un archivo de texto con un nombre clave
    public void GuardarUsuarios(){
        //string path = "usuarios.txt";
    }

    public string ObtenerPrimerUsuario()
    {
        if (_usuarios.Count > 0) // Verifica si la lista no está vacía
        {
            return _usuarios[0]; // Devuelve el primer usuario
        }
        else
        {
            return null; // Si no hay usuarios, devuelve null
        }
    }

    public int ContarUsuarios()
    {
        return _usuarios.Count;
    }


        
}

