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
        static User tempUser;

        static Repository()
        {
            users = new List<User>();
            users.Add(new User() { Login = "1", Pas = "1", Email = "1" });
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
        public static bool CheckUser(User user)
        {
            User userUC = users.FirstOrDefault(p => p.Login == user.Login);
            if (userUC == null)
            {
                return false;
            }
            else
            {
                if (userUC.Pas == user.Pas)
                {
                    tempUser = userUC;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool ChangePas(User user)
        {
            User userUP = users.FirstOrDefault(p => p.Email == user.Email);
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
        public static string[] AboutUser()
        {
            string[] str = new string[3];
            str[0] = String.Format("Логин: {0}", tempUser.Login);
            str[1] = String.Format("E-mail: {0}", tempUser.Email);
            str[2] = String.Format("Пароль: {0}", tempUser.Pas);
            return str;
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
