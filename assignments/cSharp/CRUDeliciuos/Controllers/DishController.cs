using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDeliciuos.Models;

namespace CRUDeliciuos.Controllers;

public class DishController : Controller
{
    private MyContext db;
    //Here we can "inject" our context service into the constructor
    public DishController(MyContext context) {
        //When our PostController is instantiated, it will fill in db with context
        //Remember that when context is initialized, it brings in everything we need from DbContext
        //which comes from Entity Framework Core
        db = context;
    }
//CREATE
    [HttpGet("/dishes/new")]
    public IActionResult NewDish() 
    {
        return View("New");
    }

//CREATE
    [HttpPost("/dishes/create")]
    public IActionResult AddNewDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            db.Dishes.Add(newDish);
            db.SaveChanges();

            return Redirect("/");
        } 
        else
        {
            return View("New", newDish);
        }
    }
//READ ONE
    [HttpGet("/dishes/{dishId}")]
    public IActionResult SeeOne(int dishId)
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

        if (dish == null)
        {
            return Redirect("/");
        }
        return View("ViewOne", dish);
    }
//DELETE
    [HttpPost("/dishes/{dishId}/delete")]
    public IActionResult DeleteOne(int dishId)
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

        if (dish == null)
        {
            return Redirect("/");
        }
        else
        {
            db.Dishes.Remove(dish);
            db.SaveChanges();
            return Redirect("/");
        }
    }

//UPDATE
    [HttpGet("/dishes/{dishId}/edit")]
    public IActionResult Edit(int dishId) //same name as asp-route-___ in cshtml
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

        if (dish == null)
        {
            return RedirectToAction("SeeOne");
        }
        return View("Edit", dish);
    }


//UPDATE
    [HttpPost("/dishes/{dishId}/edit")]
    public IActionResult Update(Dish editedDish, int dishId)
    {
        if (!ModelState.IsValid)
        {
            return Edit(dishId);
        }
        else
        {
            Dish? dbdish = db.Dishes.FirstOrDefault(d=> d.DishId == dishId);

            if (dbdish == null)
            {
                return RedirectToAction("Edit");
            } else
            {
                dbdish.ChefName = editedDish.ChefName;
                dbdish.DishName = editedDish.DishName;
                dbdish.Calories = editedDish.Calories;
                dbdish.Tastiness = editedDish.Tastiness;
                dbdish.UpdatedAt = DateTime.Now;

                db.Dishes.Update(dbdish);
                db.SaveChanges();

                return RedirectToAction("SeeOne", new {dishId = dishId});
            }
        }
    }
}