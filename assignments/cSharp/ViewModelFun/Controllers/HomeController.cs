using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        return View("Index", message);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers() {
        int[] numbers = new int[] {
            1, 10, 60, 300, 84, 72,
        };
        return View(numbers);
    }

    [HttpGet("/users")]
    public IActionResult Users() {
        List<User> users = new List<User>();
        users.Add(new User ("Moose", "Phillips"));
        users.Add(new User ("Sarah"));
        users.Add(new User ("Jerry"));
        users.Add(new User ("Rene", "Ricky"));
        return View (users);
    }

    [HttpGet("/user")]
    public IActionResult User() {
        User firstUser = new User("Moose", "Phillips");
        return View(firstUser);
    }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
