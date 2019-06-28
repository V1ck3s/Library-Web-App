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
            Category c1 = new Category("BD");
            Category c2 = new Category("Roman");

            Author a1 = new Author("Godlee", "Jacenta", "79");
            Author a2 = new Author("Staniforth", "Dahlia", "38");
            Author a3 = new Author("De Lasci", "Appolonia", "38");
            Author a4 = new Author("Edgar", "Margarethe	","46");
            Author a5 = new Author("Plumtree", "Jennine	","56");
            Author a6 = new Author("Hasslocher", "Nicolina", "28");
            Author a7 = new Author("Van Der Weedenburg", "Faun", "22");


            Book b1 = new Book("Purple Ball, The (Lilovyy shar)", "2010", a1, "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.", c1);
            Book b2 = new Book("Holy Mountain, The (Montaña sagrada, La)", "2004", a2, "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl.", c1);
            Book b3 = new Book("For the Love of Benji", "2001", a3, "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", c2);
            Book b4 = new Book("Wall, The (Die Wand)", "2000", a4, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", c1);
            Book b5 = new Book("Cold Comes the Night", "1989", a5, "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", c2);
            Book b6 = new Book("Golem, The (Golem, wie er in die Welt kam, Der)", "2013", a6, "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", c2);
            Book b7 = new Book("47 Ronin", "1978", a7, "Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.", c2);

            UserBooks ub1 = new UserBooks(b1, "01/07/2019");
            UserBooks ub2 = new UserBooks(b2, "07/07/2019");
            UserBooks ub3 = new UserBooks(b6, "15/09/2019");

            List<UserBooks> userBooks = new List<UserBooks>();
            userBooks.Add(ub1);
            userBooks.Add(ub2);
            userBooks.Add(ub3);

            User u1 = new User("Doe", "John", "25", userBooks, "johndoe", "motdepasse");

            ViewData["lastname"] = u1.Lastname;
            ViewData["firstname"] = u1.Firstname;
            ViewData["age"] = u1.Age;
            ViewData["username"] = u1.Username;
            ViewData["book1"] = u1.UserBooks[0].Book.Title; 
            ViewData["book2"] = u1.UserBooks[1].Book.Title;
            ViewData["book3"] = u1.UserBooks[2].Book.Title;
         
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }
    }
}