using System;
//are un sistema para reservar en el gimnacio

class Program
{
    static void Main(string[] args)
    {
        //instanciamos solo una vez registro
        Registro registro = new Registro();


        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to MUCACRAN GYM\nPlease choose one of the options you want");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Registrate\n");
            Console.WriteLine("What classes do you want to take?");
            Console.WriteLine("  2. Clases de Boxeo");
            Console.WriteLine("  3. Clases de CrossFit");
            Console.WriteLine("  4. Clases de Yoga");
            Console.WriteLine("  5. Clases de Zumba");
            Console.WriteLine("  6. Clases de Karate");
            Console.WriteLine("  7. Quit\n");
            Console.Write("Select a choise from the menu: ");
            
            string choice = Console.ReadLine();

            Clases registerClass = null;
            
            switch (choice)
            {
                case "1":
                    Usuario usuario = new Usuario();
                    usuario.Registrar(registro);                    
                    registro.GuardarRegistro();
                    break;
                case "2":
                    //registro.MostrarRegistro();
                    registerClass = new Boxeo();
                    break;
                case "3":
                    registerClass = new Crosfit();
                    break;
                case "4":
                    registerClass = new Yoga();
                    break;
                case "5":
                    registerClass = new Zumba();
                    break;
                case "6":
                    registerClass = new Karate();
                    break;
                case "7":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }
            
            if (registerClass != null)
            {
                registerClass.ejectRegister();
            }
            
        }
    }
}