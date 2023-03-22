using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginandReg.Models;
using Microsoft.AspNetCore.Identity;
using Login.Models;

namespace LoginandReg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext db;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }

    // public IActionResult Index()
    // {
    //     return View("Index");
    // }

    // [HttpPost("/register")]
    // public IActionResult RegisterNow (User newUser)
    // {
    //     if(!ModelState.IsValid)
    //     {
    //         return View("Index", newUser);
    //     }
    //     else
    //     {
    //         PasswordHasher<User> hash = new PasswordHasher<User>();
    //         newUser.Password = hash.HashPassword(newUser, newUser.Password);

    //         db.Users.Add(newUser);
    //         db.SaveChanges();

    //         HttpContext.Session.SetInt32("UUID", newUser.UserId);

    //         return Redirect("/success");
    //     }
    // }

    // [HttpPost("/login")]
    // public IActionResult Login(LoginUser userSubmission)
    // {    
    // if(ModelState.IsValid)    
    // {        
    //     // See if Email exists in the database     
    //     User? userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);        
    //     // If no user exists with the provided email        
    //     if(userInDb == null)        
    //     {            
    //         // Add an error to ModelState and return to View!            
    //         ModelState.AddModelError("LoginEmail", "Invalid Email/Password");            
    //         return View("Index", userSubmission);        
    //     }  
    //     else    // Otherwise, we have a user, now we need to check their password                 
    //     {
    //         // Initialize hasher object        
    //         PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();                    
    //         // Verify provided password against hash stored in db        
    //         var result = hash.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);                                         
    //         if(result == 0) // saying if the password does not exist      
    //         {            
    //             ModelState.AddModelError("LoginEmail", "Invalid Email/Password");            
    //             return View("Index", userSubmission); 
    //         } 


    //         // Handle success (this should route to an internal page)  
    //         HttpContext.Session.SetInt32("UUID", userInDb.UserId);

    //         return Redirect("/success");
    //     }
    // }
    // else
    // {
    //     return View ("Index", userSubmission);
    // }
    // }

    // [HttpGet("/success")]
    // public IActionResult Success () 
    // {
    //     return View("Yes");
    // }

    // // public IActionResult Privacy()
    // // {
    // //     return View();
    // // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
