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
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Registrate");
            Console.WriteLine("  2. Clases de Boxeo");
            Console.WriteLine("  3. Clases de CrossFit");
            Console.WriteLine("  4. Clases de Yoga");
            Console.WriteLine("  5. Clases de Zumba");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choise from the menu: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Tú elegiste: {choice}");
                    Usuario usuario = new Usuario();
                    usuario.Registrar(registro);                    
                    registro.GuardarRegistro();
                    break;
                case "2":
                    Console.WriteLine($"tu elegistes: {choice}");
                    registro.MostrarRegistro();
                    
                    Console.ReadLine();
                    break;
                case "3":
                    Crosfit crosfit = new Crosfit();
                    //crosfit.Clasede();
                    Console.WriteLine(crosfit.GetNombreClass());
                    Console.ReadLine();

                    break;
                case "4":
                    Console.WriteLine($"tu elegistes: {choice}");
                    Yoga yoga = new Yoga();
                    Console.WriteLine(yoga.GetNombreClass());
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine($"tu elegistes: {choice}");

                    break;
                case "6":
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