using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.AspNetCore.Identity;

namespace TheWall.Controllers;

public class UserController : Controller 
{
    private MyContext db;
    public UserController(MyContext context) {
        db = context;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("LogReg");
    }

    [HttpPost("/register")]
    public IActionResult RegisterNow (User newUser)
    {
        if(!ModelState.IsValid)
        {
            return View("LogReg", newUser);
        }
        else
        {
            PasswordHasher<User> hashbrowns = new PasswordHasher<User>();
            newUser.Password = hashbrowns.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UUID", newUser.UserId);

            return Redirect("/messages");
        }
    }

    [HttpPost("/login")]
    public IActionResult Login(LoginUser userSubmission)
    {    
    if(ModelState.IsValid)    
    {        
        // If initial ModelState is valid, query for a user with the provided email        
        User? userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);        
        // If no user exists with the provided email        
        if(userInDb == null)        
        {            
            // Add an error to ModelState and return to View!            
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");            
            return View("LogReg");        
        }   


        // Otherwise, we have a user, now we need to check their password                 
        // Initialize hasher object        
        PasswordHasher<LoginUser> hashbrowns = new PasswordHasher<LoginUser>();                    
        // Verify provided password against hash stored in db        
        var result = hashbrowns.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);                                    // Result can be compared to 0 for failure        
        if(result == 0)       
        {            
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");            
            return View("LogReg"); 
        } 


        // Handle success (this should route to an internal page)  
        HttpContext.Session.SetInt32("UUID", userInDb.UserId);

        return Redirect("/messages");
    } 
    else 
    {
        return View("LogReg");
    }
    }


    [HttpPost("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}