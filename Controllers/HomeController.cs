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
        ViewBag.palabra = LogicaAhorcado.palabra;
        return View();
    }

    public IActionResult ArriesgarLetra(string caracter)
    {
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.letra = LogicaAhorcado.ArriesgarLetra(caracter);
        return View("JugarAhorcado");
    }
        public IActionResult ArriesgarPalabra(string texto)
    {
        ViewBag.palabra = LogicaAhorcado.palabra;
        ViewBag.palabraFinal = texto;
        return View("JugarAhorcado");
    }
    
}
