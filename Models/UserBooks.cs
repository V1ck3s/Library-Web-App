using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class UserBooks
    {
        private Book book;
        private string returnDate;

        public UserBooks(Book book, string returnDate)
        {
            this.Book = book;
            this.ReturnDate = returnDate;
        }

        public Book Book { get => book; set => book = value; }
        public string ReturnDate { get => returnDate; set => returnDate = value; }
    }
}
