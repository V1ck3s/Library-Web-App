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
                    UserBooks ub4 = new UserBooks(b, DateTime.Now.ToString());
                    FakeDB.delUserBooks(ub4);

                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}