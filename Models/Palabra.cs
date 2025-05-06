public class Palabra{
    public string Texto{get; private set;}
    public List<char> Cadena{get; private set;}

    public Palabra(string texto, List<char> cadena)
    {
        Texto = texto;
        Cadena = cadena;
    }
}