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
        ViewBag.palabra = LogicaAhorcado.GenerarPalabra();
        return View();
    }

    public IActionResult CompararCaracter(string caracter, string texto)
    {
        Palabra palabra = new Palabra(texto);
        ViewBag.palabraParcial = LogicaAhorcado.CompararCaracter(caracter, palabra);
        return View("JugarAhorcado");
    }
    
}
