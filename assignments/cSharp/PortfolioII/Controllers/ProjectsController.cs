using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;

public class ProjectsController : Controller {

    [HttpGet("/projects")]
    public ViewResult Project()
    {
        return View();
    }
}