using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Library.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDB.getListBooks());
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int? id)
        {
            foreach (Book b in FakeDB.getListBooks())
            {
                if (b.Id == id)
                {
                    return View(b);
                }
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            foreach (Book b in FakeDB.getListBooks())
            {
                if (b.Id == id)
                {
                    return View(b);
                }
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBook(int id, IFormCollection collection)
        {
            try
            {
                //int idB = Int32.Parse(collection["Id"]);
                string titleB = collection["Title"];
                string yearB = collection["Year"];

                string descriptionB = collection["Description"];

                Author author1 = new Author("", "", "");
                Category category1 = new Category("");

                foreach (Author a in FakeDB.getAuthorList())
                {
                    if (a.Lastname == collection["Author.Lastname"])
                    {
                        author1 = a;
                        break;
                    }
                }

                foreach (Category c in FakeDB.getCategoryList())
                {
                    if (c.CategoryBook == collection["CategoryBook.CategoryBook"])
                    {
                        category1 = c;
                        break;
                    }
                }
                //Book b = new Book(idB, titleB, yearB, author1, descriptionB, category1);
                foreach (Book book in FakeDB.getListBooks())
                {
                    if (book.Id == id)
                    {
                        book.Title = titleB;
                        book.Year = yearB;
                        book.Description = descriptionB;
                        book.Author = author1;
                        book.CategoryBook = category1;
                        break;
                    }
                }
                
                


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBook(int id, IFormCollection collection)
        {
            
            try
            {
                int idB = Int32.Parse(collection["Id"]);
                string titleB = collection["Title"];
                string yearB = collection["Year"];
                
                string descriptionB = collection["Description"];
                
                Author author1 = new Author("","","");
                Category category1 = new Category("");
                foreach(Author a in FakeDB.getAuthorList())
                {
                    if(a.Lastname == collection["Author.Lastname"])
                    {
                        author1 = a;
                        break;
                    }
                }
                
                foreach (Category c in FakeDB.getCategoryList())
                {
                    if (c.CategoryBook == collection["CategoryBook.CategoryBook"])
                    {
                        category1 = c;
                        break;
                    }
                }

                Book b = new Book(idB,titleB,yearB,author1,descriptionB,category1);
                FakeDB.addBook(b);
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        

        public IActionResult DeleteBook(int? id)
        {
            foreach (Book b in FakeDB.getListBooks())
            {
                if (b.Id == id)
                {
                    FakeDB.deleteBook(b.Id);
                    break;
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}