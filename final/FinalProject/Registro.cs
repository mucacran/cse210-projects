class Registro{
    private List<Usuario> _usuarios;
    private string path = "registro.txt";
    
    
    public Registro(){
        _usuarios = new List<Usuario>();
        CargarRegistro();

    }

// añadir registro
    public void AddRegistro(Usuario usuario){
        _usuarios.Add(usuario);
    }

// mostrar registro
    public void MostrarRegistro(){
        Console.WriteLine("Registro de usuarios:");
        if (_usuarios.Count == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
        else
        {
            foreach (var u in _usuarios)
            {
                Console.WriteLine($"- {u.Nombre} {u.Apellido}");
            }
        }
    }

    // guardar en un archivo el registro
    public void GuardarRegistro(){

        LimpiarRegistro();
        
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            foreach (var u in _usuarios)
            {
                writer.WriteLine($"{u.Nombre},{u.Apellido},{u.Correo},{u.Password},{u.Telefono}");
            }
        }
        Console.WriteLine();
        Console.WriteLine("******************************");
        Console.WriteLine("User registered successfully\nPress enter to continue...");
        Console.WriteLine("******************************");
        Console.ReadLine();
    }


    private void CargarRegistro()
    {
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 5)
                {
                    Usuario usuario = new Usuario(parts[0], parts[1], parts[2], parts[3], parts[4]);
                    AddRegistro(usuario); // Usa AddRegistro para evitar duplicados
                }
            }
        }
    }

    //limpia el contenido del archivo de registro
    public void LimpiarRegistro(){
        //File.Delete(path);
        File.WriteAllText(path, ""); // Escribe contenido vacío
    }

}