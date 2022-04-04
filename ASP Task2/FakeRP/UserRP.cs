using ASP_Task2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Task2.FakeRP
{
    public class UserRP
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id=1,
                Name="Cristiano",
                Surname="Ronaldo",
                Age=38
            },
            new User
            {
                Id=1,
                Name="Leonel",
                Surname="Messi",
                Age=34
            },
            new User
            {
                Id=1,
                Name="Alex",
                Surname="Sander",
                Age=22
            }
        };

        public List<User> GetAllUsers()
        {
            return Users;
        }
    }
}
