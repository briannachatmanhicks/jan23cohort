using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers;

public class ChefController : Controller 
{
    private MyContext db;
    
    public ChefController(MyContext context) {
        
        db = context;
    }

    [HttpGet("/")]
    public IActionResult Index(){
        return View("ChefList");
    }

    [HttpGet("chefs/add")]
    public IActionResult ChefForm(){
        return View("Add");
    }

    [HttpPost("chefs/create")]
    public IActionResult CreateChef(Chef newChef){
        if(ModelState.IsValid){
            db.Chefs.Add(newChef);
            db.SaveChanges();
            return View("ChefList");
        } 
        return View("Add");
    }

}