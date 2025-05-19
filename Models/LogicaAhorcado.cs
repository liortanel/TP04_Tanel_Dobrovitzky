public class LogicaAhorcado
{
    public static string palabra { get; private set; }
    public static string palabraFinal { get; private set; }
    public static char[] palabraFinalChar { get; private set; }
    public static List<char> arriesgadas { get; private set; }
    public static int intentosFallidos { get; private set; }
    public static bool adivino { get; private set; }
    public static bool encontrada { get; private set; }
    public static string GenerarPalabra()
    {
        Random rnd = new Random();
        List<string> palabras = new List<string>(){
        "mesa","silla","perro","gato","casa","arbol","coche","camino","flor","cielo",
"pan","queso","vaso","plato","libro","lapiz","reloj","zapato","puerta","ventana",
"pared","suelo","techo","nube","rio","lago","mar","montana","piedra","fuego",
"luz","sombra","tren","avion","barco","calle","parque","puente","papel","tijera",
"camisa","pantalon","campana","banco","pasto","humo","planta","tierra","arena","camion",
"tractor","pala","cuchara","cuchillo","tenedor","hoja","letra","numero","globo","carro",
"botella","cuadro","cadena","cuaderno","caja","mochila","juego","panal","pelota","fruta",
"rueda","buzo","campera","sombrero","pañuelo","balde","regla","brocha","carpeta","tablon",
"broche","botin","pulsera","cinturon","lampara","sillon","espejo","cobija","almohada","soga",
"cuadro","remera","bicicleta","martillo","clavo","tornillo","perno","llave","cerradura","candado"
        };
        string texto = palabras[rnd.Next(palabras.Count)];
        return texto;
    }
    public static void InicializarJuego()
    {
        palabra = GenerarPalabra();
        palabraFinalChar = Enumerable.Repeat('_', palabra.Length).ToArray();
        arriesgadas = new List<char>();
        intentosFallidos = 0;
        adivino = false;
    }
    public static string ArriesgarLetra(char caracter)
    {
        bool encontrada = false;
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == caracter || char.ToUpper(palabra[i]) == caracter)
            {
                encontrada = true;
                palabraFinalChar[i] = caracter;
            }
        }
        if (!encontrada)
        {
            if (!arriesgadas.Contains(char.ToLower(caracter)) && !arriesgadas.Contains(char.ToUpper(caracter)))
            {
                arriesgadas.Add(caracter);
                intentosFallidos++;
            }
        }
        palabraFinal = new string(palabraFinalChar);
        return palabraFinal;
    }
    public static bool ArriesgarPalabra(string texto)
    {
        if (texto == palabra)
        {
            adivino = true;
        }
        return adivino;
    }
    public static string DibujarAhorcado(int intentosFallidos) // ChatGPT
    {
        string[] dibujo = new string[]
        {
        "  +---+",
        "  |   |",
        "      |",
        "      |",
        "      |",
        "      |",
        "========="
        };

        if (intentosFallidos >= 1)
            dibujo[2] = "  O   |";
        if (intentosFallidos >= 2)
            dibujo[3] = "  |   |";
        if (intentosFallidos >= 3)
            dibujo[3] = " /|   |";
        if (intentosFallidos >= 4)
            dibujo[3] = " /|\\  |";
        if (intentosFallidos >= 5)
            dibujo[4] = " /    |";
        if (intentosFallidos >= 6)
            dibujo[4] = " / \\  |";

        return string.Join("\n", dibujo);
    }
}