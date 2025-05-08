public class LogicaAhorcado
{
    public static string palabra {get; private set;} = GenerarPalabra();

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

    public static string ArriesgarLetra(string caracter) 
    {
        string palabraParcial = "";
        if(palabra != "")
        {
            for(int i = 0; i < palabra.Length; i++)
            {
                if(caracter != "")
                {
                    if(palabra[i].ToString().Contains(caracter))
                    {
                        palabraParcial += caracter + " ";
                    }
                    else
                    {
                        palabraParcial += "_ ";
                    }
                }
            }
        }
        return palabraParcial; 
    }
    public static bool ArriesgarPalabra(string texto)
    {
        bool adivino = false;
        if(palabra != "")
        {
            if(texto != "")
            {
                if(palabra.Contains(texto))
                {
                    adivino = true;
                }
            }
        }
        return adivino; 
    }
}