using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using technova_ecommerce_shop.Models;

namespace technova_ecommerce_shop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private DatabaseContext _databaseContext;

    public HomeController(ILogger<HomeController> logger, DatabaseContext databaseContext)
    {
        _logger = logger;
        _databaseContext = databaseContext;
    }

    public IActionResult Index()
    {
        var categories = _databaseContext.Category.Include(p => p.Product).ToList();
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
