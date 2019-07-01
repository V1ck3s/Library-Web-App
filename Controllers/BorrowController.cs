using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BorrowController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDB.getListBooks());
        }

        public IActionResult Details(int? id)
        {

                      

            foreach(Book b in FakeDB.getListBooks())
            {
                if(b.Id == id)
                {
                    return View(b);
                }
            }


            return View();
        }

        public IActionResult Emprunter(int? id)
        {
            
            


            foreach (Book b in FakeDB.getListBooks())
            {
                if (b.Id == id)
                {
                    UserBooks ub4 = new UserBooks(b, DateTime.Now.ToString());
                    FakeDB.addUserBooks(ub4);
                    
                }
            }


            //return View();
            return RedirectToAction(nameof(Index));
        }
    }
}