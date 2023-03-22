using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.AspNetCore.Mvc.Filters; //needed for session check validation!
using Microsoft.EntityFrameworkCore;

namespace TheWall.Controllers;

public class MessageController : Controller 
{
    private MyContext db;
    //Here we can "inject" our context service into the constructor
    public MessageController(MyContext context) {
        //When our PostController is instantiated, it will fill in db with context
        //Remember that when context is initialized, it brings in everything we need from DbContext
        //which comes from Entity Framework Core
        db = context;
    }

    [HttpGet("/messages")]
    public IActionResult AllMessandComm() {
        // List<Message> everything = db.Messages
        // .Include(m => m.MAuthor)
        // .Include(m => m.CommentList)
        // // .ThenInclude(c => c.OriginalM)
        // .ToList();

        MyViewModel MyModels = new MyViewModel
        {
            AllMessages = db.Messages.ToList(),
        };

        return View("Dashboard", MyModels);
    }

    [HttpPost("/messages/create")]
    public IActionResult CreateMessage(Message newMess)
    {
        if(ModelState.IsValid)
        {
            newMess.UserId = (int)HttpContext.Session.GetInt32("UUID");
            db.Messages.Add(newMess);
            db.SaveChanges();
            return RedirectToAction("AllMessandComm");

        }else {
            return View ("Dashboard", newMess);
        }
    }
    // [HttpPost("/messages/{messageId}/addcomment")]
}