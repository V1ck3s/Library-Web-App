using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            
            return View(FakeDB.getUser());
        }

        public IActionResult Signin()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Rendre(int? id)
        {
            foreach (Book b in FakeDB.getListBooks())
            {
                if (b.Id == id)
                {
                    
                    FakeDB.delUserBooks(b);

                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}