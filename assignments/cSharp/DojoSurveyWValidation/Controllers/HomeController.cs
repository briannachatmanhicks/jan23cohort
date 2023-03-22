using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWValidation.Models;

namespace DojoSurveyWValidation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index()
    // {
    //     return View();
    // }

    [HttpGet("")]
    public IActionResult Index(){
        return View();
    }

    [HttpGet("/surveyResults")]
    public IActionResult Survey(){
        return View();
    }

    [HttpPost("/surveyResults")]
    public IActionResult Survey(Survey surveyResp){
        if (ModelState.IsValid) {
            return View("Survey", surveyResp);
        } else {
            return View("Index", surveyResp);
        }
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
