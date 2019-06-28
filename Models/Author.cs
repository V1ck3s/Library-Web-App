using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Models
{
    public class Author
    {
        private string lastname;
        private string firstname;
        private string age;

        public Author(string lastname, string firstname, string age)
        {
            this.Lastname = lastname;
            this.Firstname = firstname;
            this.Age = age;
        }

        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Age { get => age; set => age = value; }
    }
}