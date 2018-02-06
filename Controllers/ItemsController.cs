using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")]
        public ActionResult Index()
        {
            return View();
        }

        // [HttpPost("/items")]
        // public ActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        // [HttpGet("/items/create/form")]
        // public ActionResult CreateForm()
        // {
        //     return View();
        // }

        [HttpPost("/items")]
        public ActionResult Create()
        {
          Item newItem = new Item (Request.Form["new-item"]);
          newItem.Save();
          return View("Index", newItem);
        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }

    }
}
