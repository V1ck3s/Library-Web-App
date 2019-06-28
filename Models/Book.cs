using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {

        private string title;
        private string category;
        private string year;
        private Author author;
        private string description;
        private Category categoryBook;

        public Book(string title, string category, string year, Author author, string description, Category categoryBook)
        {
            this.Title = title;
            this.Category = category;
            this.Year = year;
            this.Author = author;
            this.Description = description;
            this.CategoryBook = categoryBook;
        }

        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        public string Year { get => year; set => year = value; }
        public Author Author { get => author; set => author = value; }
        public string Description { get => description; set => description = value; }
        public Category CategoryBook { get => categoryBook; set => categoryBook = value; }
    }
}
