using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User
    {
        private string lastname;
        private string firstname;
        private string age;
        private List<UserBooks> userBooks;
        private string username;
        private string password;

        public User(string lastname, string firstname, string age, List<UserBooks> userBooks, string username, string password)
        {
            this.Lastname = lastname;
            this.Firstname = firstname;
            this.Age = age;
            this.UserBooks = userBooks;
            this.Username = username;
            this.Password = password;
        }

        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Age { get => age; set => age = value; }
        public List<UserBooks> UserBooks { get => userBooks; set => userBooks = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
