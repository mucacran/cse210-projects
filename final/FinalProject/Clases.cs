class Clases
{
    private string _nombreClass;
    private string _correoR;
    private string _passwordR;

    public string Correo
    {
        get => _correoR;
        set => _correoR = value;
    }

    public string Password
    {
        get => _passwordR;
        set => _passwordR = value;
    }

    public void ejectRegister()
    {
        Welcome();
        IfRegister();
        //ElegirHorario();
        //ElegirInstructor();
        //saveRegister();
    }

    public void Welcome()
    {
        Console.Clear();
        Console.WriteLine("*********************************************");
        Console.WriteLine("Welcome to : " + GetNombreClass() + " Class");
        Console.WriteLine("*********************************************");
    }

    public Clases(string nombreClass)
    {
        _nombreClass = nombreClass;
    }

    public void IfRegister()
    {
        Console.WriteLine("Do you want to register to this class?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        Console.Write("Select a choise from the menu: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                giveMeData();
                ifRegistred();
                Console.ReadLine();
                break;
            case "2":
                Console.WriteLine("You are not registered to this class");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid choice. Press enter to continue...");
                Console.ReadLine();
                break;
        }
    }


    public string GetNombreClass()
    {
        return _nombreClass;
    }

    public void giveMeData()
    {
        Console.WriteLine("We need your email to register you");
        Console.Write("Correo: ");
        Correo = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();
    }

    public void ifRegistred()
    {
        string path = "registro.txt";
        if (!File.Exists(path))
        {
            Console.WriteLine("The log file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(path);
        bool usuarioEncontrado = false;


        //int count = 0;
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            //count++;

            if (parts.Length == 5 && parts[2].Trim() == Correo.Trim() && parts[3].Trim() == Password.Trim())
            {
                Console.WriteLine($"Welcome {parts[0].ToUpper()} {parts[1].ToUpper()}, you are registered to this class");
                usuarioEncontrado = true;
                GuardarClase(); // this saves the class to the user
                return;
            }
        }

        if (!usuarioEncontrado)
        {
            Console.WriteLine("There may be several problems:\n1. A user with that email was not found.\n2. Your username or password are not the same.\nIn any case, try again or register.");
        }
    }

    private void GuardarClase()
    {
        string path = "clases_registradas.txt";

        // Si el archivo no existe, lo creamos vacío
        if (!File.Exists(path))
        {
            using (File.Create(path)) { }
        }

        // Leer todas las líneas del archivo
        string[] lines = File.ReadAllLines(path);

        // Verificar si el correo y la clase ya están registrados
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 2 && parts[0].Trim() == Correo.Trim() && parts[1].Trim() == GetNombreClass().Trim())
            {
                Console.WriteLine("\nYou have already been registered for this class.");
                return; // Salir del método sin agregar una nueva línea
            }
        }

        // Si no se encontró, registramos la nueva entrada
        using (StreamWriter writer = new StreamWriter(path, true)) // Modo "append"
        {
            writer.WriteLine($"{Correo},{GetNombreClass()}");
        }

        Console.WriteLine("\nYour class registration has been successfully saved..");
    }


}