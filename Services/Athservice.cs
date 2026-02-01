using System;
using DentalClinic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Services
{
    internal class Athservice
    {
        private List<User> users;
        private DataService dataService;
        private string fileName = "users.json";

        public Athservice()
        {
            dataService = new DataService();
            users = dataService.LoadData<User>(fileName);

            // Add default admin user if no users exist

            if (users.Count == 0)
            {
                users.Add(new User
                {
                    Id = 1,
                    Username = "Hamza",
                    Password = "hamza123",
                    Role = "hamza",
                    FullName = "System Administrator"
                });
                dataService.SaveData(users, fileName);
            }
        }

        public User Authenticate(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password ==

password);
        }

        public void AddUser(User user)
        {
            user.Id = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;
            users.Add(user);
            dataService.SaveData(users, fileName);
        }
    }
}

