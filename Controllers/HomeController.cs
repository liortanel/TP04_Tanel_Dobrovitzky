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
    public IActionResult JugarAhorcado(char letra, string palabra)
    {
        ViewBag.letraInput = letra;
        ViewBag.palabraInput = palabra;
        ViewBag.palabra = CrearPalabra.GenerarPalabra();
        return View();
    }
}
