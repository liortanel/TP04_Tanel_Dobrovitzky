public class LogicaAhorcado
{
    public static string palabra { get; private set; } = GenerarPalabra();
    public static string palabraFinal { get; private set; }

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
        palabraFinal = "";
    }

    public static string ArriesgarLetra(char caracter)
    {
        for(int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == caracter)
            {
                palabraFinal += caracter + " ";
            }
            else
            {
                palabraFinal += "_ ";
            }
        }
        return palabraFinal;
    }
    public static bool ArriesgarPalabra(string texto)
    {
        bool adivino = false;
        if (palabra != "")
        {
            if (texto != "")
            {
                if (palabra.Contains(texto))
                {
                    adivino = true;
                }
            }
        }
        return adivino;
    }
}