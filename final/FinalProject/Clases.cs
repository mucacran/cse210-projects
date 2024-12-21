class Clases{
    private string _nombreClass;

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
                Console.WriteLine("You are registered to this class");
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
/*
    public virtual void Clasede(){
        GetNombreClass();
    }
*/

}