public class CrearPalabra
{
    public static Palabra palabra {get; private set;} = GenerarPalabra();

    public static Palabra GenerarPalabra()
    {
        Random rnd = new Random();
        List<string> palabras = new List<string>(){
        "MESA",
        "SILLA",
        };
        Palabra palabra = new Palabra(palabras[rnd.Next(palabras.Count)]);
        return palabra;
    }
}