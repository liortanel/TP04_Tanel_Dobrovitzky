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

        return View();
    }

    public IActionResult ArriesgarLetra(char caracter)
    {
        LogicaAhorcado.ArriesgarLetra(caracter);
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.palabraFinal = new string(LogicaAhorcado.palabraFinalChar);
        ViewBag.palabraFinalChar = LogicaAhorcado.palabraFinalChar;

        return View("JugarAhorcado");
    }

    public IActionResult ArriesgarPalabra(string texto)
    {
        ViewBag.Adivino = LogicaAhorcado.ArriesgarPalabra(texto);
        ViewBag.palabraFinal = texto;
        ViewBag.palabra = LogicaAhorcado.palabra;

        return View("JugarAhorcado");
    }

}
