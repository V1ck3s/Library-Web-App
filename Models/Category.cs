using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Category
    {
        private string categoryBook;

        public Category()
        {
        }

        public Category(string categoryBook)
        {
            this.CategoryBook = categoryBook;
        }

        public string CategoryBook { get => categoryBook; set => categoryBook = value; }
    }
}
