using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionPractice.Models;

namespace SessionPractice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost("")]
    public IActionResult Index(User currentUser){
        string name = currentUser.Name;
        HttpContext.Session.SetString("Name", name);

        return RedirectToAction("Dashboard", currentUser);

    }

    [HttpGet("Dashboard")]
    public IActionResult Dashboard(User currentUser) {
        return View("Dashboard", currentUser);
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
