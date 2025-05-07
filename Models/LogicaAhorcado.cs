public class LogicaAhorcado
{
    public static Palabra palabra {get; private set;} = GenerarPalabra();

    public static Palabra GenerarPalabra()
    {
        Random rnd = new Random();
        List<string> palabras = new List<string>(){
        "mesa",
        "silla",
        };
        string texto = palabras[rnd.Next(palabras.Count)];
        Palabra palabra = new Palabra(texto);
        return palabra;
    }

    public static string CompararCaracter(string caracter, Palabra palabra)
    {
        string palabraFinal = "";
        if(palabra.Texto != null)
        {
            for(int i = 0; i < palabra.Texto.Length; i++)
        {
            if(caracter != null && palabra != null)
            {
                if(palabra.Texto.Contains(caracter))
                {
                    palabraFinal += caracter;
                }
                else
                {
                    palabraFinal += "_";
                }
            }
        }
        }
        return palabraFinal; 
    }
}