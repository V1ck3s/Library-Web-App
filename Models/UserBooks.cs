using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class UserBooks
    {
        private Book book;
        private User user;
        private DateTime returnDate;

        public UserBooks(Book book, User user, DateTime returnDate)
        {
            this.Book = book;
            this.User = user;
            this.ReturnDate = returnDate;
        }

        public Book Book { get => book; set => book = value; }
        public User User { get => user; set => user = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
    }
}
