using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using rubricaWeb.Models;

namespace rubricaWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;

    public HomeController(ILogger<HomeController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index()
    {
        List<string> lista = new();

        lista.Add("marco1");
        lista.Add("marco2");
        lista.Add("marco3");

        return View( lista );
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult pagina1()
    {
        return View();
    }
    public IActionResult Marconi()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
