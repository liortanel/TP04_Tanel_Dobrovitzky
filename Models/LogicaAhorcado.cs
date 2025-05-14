public class LogicaAhorcado
{
    public static string palabra { get; private set; } = GenerarPalabra();
    public static string palabraFinal { get; private set; }
    public static char[] palabraFinalChar {get; private set;}
    public static List<char> arriesgadas {get; private set;}
    
 public static bool encontrada {get; private set;}
    public static string GenerarPalabra()
    {
        Random rnd = new Random();
        List<string> palabras = new List<string>(){
        "mesa",
        "silla",
        };
        string texto = palabras[rnd.Next(palabras.Count)];
        return texto;
    }
    public static void InicializarJuego() 
{
    palabraFinalChar = Enumerable.Repeat('_', palabra.Length).ToArray();
    arriesgadas = new List<char>();
}
    public static string ArriesgarLetra(char caracter)
{
    bool encontrada = false;
    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra[i] == caracter)
        {
            encontrada = true;
            palabraFinalChar[i] = caracter;
        }
    }
    if(!encontrada)
    {
        if(!arriesgadas.Contains(caracter))
        {
            arriesgadas.Add(caracter);
        }
    }
    palabraFinal = new string(palabraFinalChar);
    return palabraFinal;
}
    public static bool ArriesgarPalabra(string texto)
    {
        bool adivino = false;
        if (texto == palabra)
        {
            adivino = true;
        }
        return adivino;
    }
}