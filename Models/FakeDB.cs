using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public static class FakeDB
    {
        static Category c1 = new Category("BD");
        static Category c2 = new Category("Roman");

        static Author a1 = new Author("Godlee", "Jacenta", "79");
        static Author a2 = new Author("Staniforth", "Dahlia", "38");
        static Author a3 = new Author("De Lasci", "Appolonia", "38");
        static Author a4 = new Author("Edgar", "Margarethe	", "46");
        static Author a5 = new Author("Plumtree", "Jennine	", "56");
        static Author a6 = new Author("Hasslocher", "Nicolina", "28");
        static Author a7 = new Author("Van Der Weedenburg", "Faun", "22");

        static Book b1 = new Book(1, "Purple Ball, The (Lilovyy shar)", "2010", a1, "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.", c1);
        static Book b2 = new Book(2, "Holy Mountain, The (Montaña sagrada, La)", "2004", a2, "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl.", c1);
        static Book b3 = new Book(3, "For the Love of Benji", "2001", a3, "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", c2);
        static Book b4 = new Book(4, "Wall, The (Die Wand)", "2000", a4, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", c1);
        static Book b5 = new Book(5, "Cold Comes the Night", "1989", a5, "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", c2);
        static Book b6 = new Book(6, "Golem, The (Golem, wie er in die Welt kam, Der)", "2013", a6, "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", c2);
        static Book b7 = new Book(7, "47 Ronin", "1978", a7, "Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.", c2);

        static UserBooks ub1 = new UserBooks(b1, "01/07/2019");
        static UserBooks ub2 = new UserBooks(b2, "07/07/2019");
        static UserBooks ub3 = new UserBooks(b6, "15/09/2019");

        static List<UserBooks> userBooks = new List<UserBooks>();
        

        static User u1 = new User("Doe", "John", "25", userBooks, "johndoe", "motdepasse");

        static List<Book> listBooks = new List<Book>();

        static List<Author> listAuthor = new List<Author>();
        static List<Category> listCategory = new List<Category>();


        public static void initDB()
        {
            userBooks.Add(ub1);
            userBooks.Add(ub2);
            userBooks.Add(ub3);

            listBooks.Add(b1);
            listBooks.Add(b2);
            listBooks.Add(b3);
            listBooks.Add(b4);
            listBooks.Add(b5);
            listBooks.Add(b6);
            listBooks.Add(b7);

            listAuthor.Add(a1);
            listAuthor.Add(a2);
            listAuthor.Add(a3);
            listAuthor.Add(a4);
            listAuthor.Add(a5);
            listAuthor.Add(a6);
            listAuthor.Add(a7);

            listCategory.Add(c1);
            listCategory.Add(c2);

        }
        public static void addUserBooks(UserBooks uB)
        {
            userBooks.Add(uB);
        }
        public static void delUserBooks(Book b)
        {
            int index = 0;
            foreach(UserBooks uB in userBooks)
            {
                if(uB.Book == b)
                {
                    index = userBooks.IndexOf(uB);
                }
            }
            userBooks.RemoveAt(index);
        }
        public static void addUserBooks(Book b)
        {
            listBooks.Add(b);
        }
        public static List<Book> getListBooks()
        {
            return listBooks;
        }

        public static List<UserBooks> getListUserBooks()
        {
            return userBooks;
        }
        public static User getUser()
        {
            return u1;
        }
        public static void deleteBook(int? id)
        {
            
            foreach (Book b in listBooks)
            {
                int index = 0;
                if (b.Id == id)
                {
                    index = listBooks.IndexOf(b);
                    listBooks.Remove(b);
                    break;
                }
                
            }
            
        }

        public static void addBook(Book b)
        {
            listBooks.Add(b);

        }

        public static List<Author> getAuthorList()
        {
            return listAuthor;
        }

        public static List<Category> getCategoryList()
        {
            return listCategory;
        }
    }
    
}
