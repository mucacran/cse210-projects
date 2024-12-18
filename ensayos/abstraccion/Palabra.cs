
class Palabra{
    private string _palabra;

    public Palabra(){
        _palabra = "Sergio Bravo Moran";
    }

    public string AviSo(){
        return $"la palabra es:  {_palabra}";
    }

    public void MenSaje(){
        Console.WriteLine("la palabra declarada es " + _palabra);
        //return $"Este es otro mensaje: {palabra}";
    }

    public void IsPalindrome(){
        if(_palabra == null){
            Console.WriteLine("Palabra no ha sido declarado");
        }
        else{
            Console.WriteLine($"A trabajar se ha dicho {_palabra}\n");

            Console.WriteLine(ConAunaSolaPalabra(_palabra));

            string _newPalbra = ConAunaSolaPalabra(_palabra);

            Console.WriteLine(DarleVueltaAPalabra(_newPalbra));

            if(_palabra == _newPalbra){
                Console.WriteLine("Son identicas tanto al reves como al derecho");
            }
            else{
                Console.WriteLine("El texto no es identico");
            }
        }

    }

    static string ConAunaSolaPalabra(string _palabra){
        _palabra = _palabra.ToLower().Replace(" ", "");

        return _palabra;
    }

    static string DarleVueltaAPalabra(string _palabra){
        char[] carteres = _palabra.ToCharArray();
        Array.Reverse(carteres);
        return new string(carteres);
    }


}