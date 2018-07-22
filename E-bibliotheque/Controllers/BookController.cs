using E_librairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_librairy.Controllers
{
    public class BookController : Controller
    {
        public BookController()
        {
            Database.InitDatabase();
        }

        public ActionResult Index()
        {
            ViewData["books"] = Database.Books;
            return View("List_Books");
        }

        public ActionResult GetBook(int id)
        {
            Book book = Database.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return View("Error");
            }
            ViewData["book"] = book;
            return View("Book");
        }

        public ActionResult SearchBook(string keyword)
        {
            keyword = keyword?.ToLower();
            ViewData["keyword"] = keyword;
            ViewData["books"] = Database.Books.FindAll(book => book.Title.ToLower().Contains(keyword) || book.Author.Name.ToLower().Contains(keyword));
            return View("Search");
        }
    }
}