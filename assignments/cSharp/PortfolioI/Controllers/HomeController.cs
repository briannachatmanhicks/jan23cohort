using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;

public class HomeController : Controller 
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "This is my index";
    }

    [HttpGet("/projects")]
    public string Project()
    {
        return "These are my projects";
    }

    [HttpGet("/contact")]
    public string Contact()
    {
        return "This is my contact";
    }
}