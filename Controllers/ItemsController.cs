using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")]
        public ActionResult Index()
        {
          List<Item> allItems = Item.GetAll();
          return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        // [HttpPost("/items")]
        // public ActionResult Create()
        // {
        //   Item newItem = new Item (Request.Form["new-item"]);
        //   List<Item> allItems = Item.GetAll();
        //   return View("Index", allItems);
        // }

        // [HttpGet("/items/{id}")]
        // public ActionResult Details(int id)
        // {
        //   Item item = Item.Find(id);
        //   Dictionary<string, object> model = new Dictionary<string, object>();
        //   Category category = Category.Find(item.GetCategoryId());
        //   model.Add("item", item);
        //   model.Add("category", category);
        //   return View(item);
        // }

        [HttpGet("/categories/{categoryId}/items/new")]
        public ActionResult CreateForm(int categoryId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Category category = Category.Find(categoryId);
            // List<Item> allItems = foundCategory.GetItems();
            // model.Add("item", item);
            // model.Add("category", category);
            // return View(model);
            return View(category);
        }

        [HttpGet("/categories/{categoryId}/items/{itemId}")]
       public ActionResult Details(int categoryId, int itemId)
       {
          Item item = Item.Find(itemId);
          Dictionary<string, object> model = new Dictionary<string, object>();
          Category category = Category.Find(categoryId);
          model.Add("item", item);
          model.Add("category", category);
          return View(item);
       }

        // [HttpPost("/items/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Item.ClearAll();
        //     return View();
        // }

    }
}
