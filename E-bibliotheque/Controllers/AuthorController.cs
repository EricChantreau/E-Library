using E_librairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_librairy.Controllers
{
    public class AuthorController : Controller
    {
        public AuthorController()
        {
            Database.InitDatabase();
        }

        public ActionResult Index()
        {
            ViewData["authors"] = Database.Authors;
            return View("List_Authors");
        }

        public ActionResult GetAuthor(int id)
        {
            Author author = Database.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return View("Error");
            }
            ViewData["author"] = author;
            ViewData["books"] = Database.Books.FindAll(b => b.Author.Id == id);
            return View("Author");
        }
    }
}