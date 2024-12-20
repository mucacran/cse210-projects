using System;
//are un sistema para reservar en el gimnacio

class Program
{
    static void Main(string[] args)
    {
        
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Registrate");
            Console.WriteLine("  2. Clase de boxeo");
            Console.WriteLine("  3. Clse de Danza");
            Console.WriteLine("  4. Clase de Yoga");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choise from the menu: ");
            
            string choice = Console.ReadLine();
            
            //Activity activity = null;
            Usuario usuario = new Usuario();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Tú elegiste: {choice}");
                    usuario.Registrar();                    
                    
                    break;
                case "2":
                    Console.WriteLine($"tu elegistes: {choice}");
                    Usuario user1 = usuario.ObtenerPrimerUsuario();

                    if (user1 != null)
                    {
                        Console.WriteLine($"Hola usuario: {user1.Nombre}");
                    }
                    else
                    {
                        Console.WriteLine("No hay usuarios registrados en el sistema.");
                    }
                    Console.WriteLine($"Usuarios registrados: {usuario.ContarUsuarios()}");

                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine($"tu elegistes: {choice}");

                    break;
                case "4":
                    Console.WriteLine($"tu elegistes: {choice}");

                    break;
                case "5":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }
            /*
            if (activity != null)
            {
                activity.RunActivity();
            }
            */
        }
    }
}