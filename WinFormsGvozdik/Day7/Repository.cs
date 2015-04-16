using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public static class Repository
    {
        static List<User> users;
        static Repository()
        {
            users = new List<User>();
        }
        public static bool AddNewUser(User user)
        {
            User userNU = users.FirstOrDefault(p => p.Login == user.Login);
            if (userNU == null)
            {
                users.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool UpdateUserPas(User user)
        {
            User userUP = users.FirstOrDefault(p => p.Login == user.Login);
            if (userUP == null)
            {
                return false;
            }
            else
            {
                userUP.Pas = user.Pas;
                return true;
            }
        }
        public static bool UpdateUserFirstName(User user)
        {
            User userUFN = users.FirstOrDefault(p => p.Login == user.Login);
            if (userUFN == null)
            {
                return false;
            }
            else
            {
                userUFN.FirstName = user.FirstName;
                return true;
            }
        }
        public static bool UpdateUserLastName(User user)
        {
            User userULN = users.FirstOrDefault(p => p.Login == user.Login);
            if (userULN == null)
            {
                return false;
            }
            else
            {
                userULN.FirstName = user.FirstName;
                return true;
            }
        }
        public static bool RemoveUser(User user)
        {
            User userUR = users.FirstOrDefault(p => p.Login == user.Login);
            if (userUR == null)
            {
                return false;
            }
            else
            {
                users.Remove(user);
                return true;
            }
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Pas { get; set; }
        public string Email { get; set; }
    }
}
