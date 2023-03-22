using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
    public class FormController : Controller
    {
        // [HttpGet("/results")]
        // public ViewResult Results() {
        //     return View();
        // }

        [HttpPost("/results")]
        public IActionResult Results (string name, string dojoLocation, string favLang, string comment) {
            ViewBag.name = $"{name}";
            ViewBag.dojoLocation = $"{dojoLocation}";
            ViewBag.favLang = $"{favLang}";
            ViewBag.comment =$"{comment}";

            return View();
        }
    }