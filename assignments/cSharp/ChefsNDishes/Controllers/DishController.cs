using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers;

public class DishController : Controller 
{
    private MyContext db;
    
    public DishController(MyContext context) {
        
        db = context;
    }

    // [HttpGet("dishes")]
    // public IActionResult AllDishes(){
    //     List<Dish> allDishes = db.Dishes.Include(d => d.Chef).ToList();
    // }
}