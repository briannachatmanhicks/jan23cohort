using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWModel.Models;

namespace DojoSurveyWModel.Controllers;

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
    // [HttpGet("survey")]
    // public IActionResult Submission() {
    //     return View();
    // }

    [HttpPost("survey")]
    public IActionResult Submission(Survey yourSurvey)
    {
        return View("Submission", yourSurvey);
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
