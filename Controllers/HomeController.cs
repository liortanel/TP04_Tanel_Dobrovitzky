using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Tanel_Dobrovitzky.Models;

namespace TP04_Tanel_Dobrovitzky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult JugarAhorcado(string texto)
    {
        LogicaAhorcado.InicializarJuego();
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.palabraFinal = new string(LogicaAhorcado.palabraFinalChar);
        ViewBag.palabraFinalChar = LogicaAhorcado.palabraFinalChar;
        ViewBag.arriesgadas = LogicaAhorcado.arriesgadas;

        return View();
    }

    public IActionResult ArriesgarLetra(char caracter)
    {
        LogicaAhorcado.ArriesgarLetra(caracter);
        string Palabra = LogicaAhorcado.palabra;
        string PalabraFinal = new String(LogicaAhorcado.palabraFinalChar);
        ViewBag.palabra = Palabra;
        ViewBag.palabraFinal = PalabraFinal;
        ViewBag.palabraFinalChar = LogicaAhorcado.palabraFinalChar;
        ViewBag.arriesgadas = LogicaAhorcado.arriesgadas;
        System.Console.WriteLine(PalabraFinal);
        if(PalabraFinal == Palabra)
        {
        return RedirectToAction("Gano");
        }       

        return View("JugarAhorcado");
    }

    public IActionResult ArriesgarPalabra(string texto)
    {
        bool adivino = LogicaAhorcado.ArriesgarPalabra(texto);
        ViewBag.Adivino = adivino;
        ViewBag.palabra = LogicaAhorcado.palabra;
        if (adivino)
        {
            ViewBag.palabraFinal = texto;
            return RedirectToAction("Gano");
        }
        else
        {
            ViewBag.palabraFinal = LogicaAhorcado.palabraFinalChar;
            ViewBag.Adivino = false;
            return View("JugarAhorcado");
        }
    }
    public IActionResult Gano()
    {
        return View();
    }

}
