using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public double Money { get; set; }
        
        public bool IsAdmin { get; set; }

        public User(string firstName, string lastName,DateTime dateOfBirth,string email,string password,double money,bool isAdmin) 
        { 
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            Money = money;
            IsAdmin = isAdmin;
        }
    }
}
