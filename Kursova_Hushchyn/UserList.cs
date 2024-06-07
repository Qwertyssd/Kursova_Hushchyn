using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kursova_Hushchyn
{
    public class UserList
    {
        public List<User> Users { get; set; }

        public UserList()
        {
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUserByEmail(string email)
        {
            var user = Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                Users.Remove(user);
            }
        }

        public User GetUserByEmail(string email)
        {
            return Users.FirstOrDefault(u => u.Email == email);
        }

        public List<User> GetAllUsers()
        {
            return new List<User>(Users);
        }

        public List<User> GetUsersByLastName(string lastName)
        {
            return Users.Where(u => u.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool AuthenticateUser(string email, string password)
        {
            User user = Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }

        public List<User> GetAdminUsers()
        {
            return Users.Where(u => u.IsAdmin).ToList();
        }
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var user in Users)
                {
                    writer.WriteLine($"{user.FirstName}|{user.LastName}|{user.DateOfBirth:yyyy-MM-dd}|{user.Email}|{user.Password}|{user.Money}|{user.IsAdmin}");
                }
            }
        }

      
        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Users.Clear();
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 7)
                    {
                        string firstName = parts[0];
                        string lastName = parts[1];
                        DateTime dateOfBirth = DateTime.Parse(parts[2]);
                        string email = parts[3];
                        string password = parts[4];
                        double money = double.Parse(parts[5]);
                        bool isAdmin = bool.Parse(parts[6]);

                        Users.Add(new User(firstName, lastName, dateOfBirth, email, password,money, isAdmin));
                    }
                }
            }
        }
    }


}
