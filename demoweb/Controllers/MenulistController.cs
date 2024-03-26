using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demoweb.Models;

namespace demoweb.Controllers;

public class MenulistController : Controller
{
    private readonly ILogger<MenulistController> _logger;

    public MenulistController(ILogger<MenulistController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
