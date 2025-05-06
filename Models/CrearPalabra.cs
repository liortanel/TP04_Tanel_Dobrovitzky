public class CrearPalabra
{
    public static Palabra palabra {get; private set;} = GenerarPalabra();

    public static Palabra GenerarPalabra()
    {
        Random rnd = new Random(); List<char> cadena = new List<char>();
        List<string> palabras = new List<string>(){
        "mesa",
        "silla",
        };
        string texto = palabras[rnd.Next(palabras.Count)];
        foreach(char caracter in texto)
        {
            cadena.Add(caracter);
        }
        Palabra palabra = new Palabra(texto, cadena);
        return palabra;
    }
}