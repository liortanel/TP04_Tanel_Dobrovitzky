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
    public IActionResult JugarAhorcado()
    {
        LogicaAhorcado.InicializarJuego();
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.palabraFinal = new string(LogicaAhorcado.palabraFinalChar);
        ViewBag.palabraFinalChar = LogicaAhorcado.palabraFinalChar;
        ViewBag.arriesgadas = LogicaAhorcado.arriesgadas;
        ViewBag.dibujo = LogicaAhorcado.DibujarAhorcado(LogicaAhorcado.intentosFallidos);
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
        ViewBag.intentosFallidos = LogicaAhorcado.intentosFallidos;
        ViewBag.dibujo = LogicaAhorcado.DibujarAhorcado(LogicaAhorcado.intentosFallidos);
        if(PalabraFinal == Palabra)
        {
        return RedirectToAction("Gano");
        }
        if(LogicaAhorcado.intentosFallidos == 6)
        {
        return RedirectToAction("Perdio");
        }       

        return View("JugarAhorcado");
    }

    public IActionResult ArriesgarPalabra(string texto)
    {
        bool adivino = LogicaAhorcado.ArriesgarPalabra(texto);
        ViewBag.Adivino = adivino;
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.arriesgadas = LogicaAhorcado.arriesgadas;
        if (adivino)
        {
            ViewBag.palabraFinal = texto;
            return RedirectToAction("Gano");
        }
        else
        {
            ViewBag.palabraFinal = LogicaAhorcado.palabraFinalChar;
            ViewBag.Adivino = false;
            return RedirectToAction("Perdio");
        }
    }
    public IActionResult Gano()
    {
        ViewBag.intentosFallidos = LogicaAhorcado.intentosFallidos;
        return View();
    }
    public IActionResult Perdio()
    {
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.dibujo = LogicaAhorcado.DibujarAhorcado(LogicaAhorcado.intentosFallidos);
        return View();
    }
    public IActionResult Reglas()
    {
        return View();
    }

}
