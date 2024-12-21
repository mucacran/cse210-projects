class Clases{
    private string _nombreClass;
    private string _correoR;
    private string _passwordR;

    public string Correo{
        get => _correoR;
        set => _correoR = value;
    }

    public string Password{
        get => _passwordR;
        set => _passwordR = value;
    }

    public void ejectRegister(){
        Welcome();
        IfRegister();
        //ElegirHorario();
        //ElegirInstructor();
        //saveRegister();
    }

    public void Welcome(){
        Console.Clear();
        Console.WriteLine("*********************************************");
        Console.WriteLine("Welcome to : " + GetNombreClass() + " Class");
        Console.WriteLine("*********************************************");
        Console.ReadLine();
    }

    public Clases(string nombreClass){
        _nombreClass = nombreClass;
    }

    public void IfRegister(){
        Console.WriteLine("Do you want to register to this class?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        Console.Write("Select a choise from the menu: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                giveMeData();
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


    public string GetNombreClass(){
        return _nombreClass;
    }

    public void giveMeData(){
        Console.WriteLine("Necesitamos sus datos para registrarlo");
        Console.Write("Correo: ");
        Correo = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();
    }

    public void ifRegistred(){
        string path = "registro.txt";
        if (!File.Exists(path))
        {
            Console.WriteLine("El archivo de registro no existe.");
            return;
        }

        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts[0] == Correo && parts[1] == Password)
            {
                Console.WriteLine("You are registered to this class");
                return;
            }
        }
    }

}