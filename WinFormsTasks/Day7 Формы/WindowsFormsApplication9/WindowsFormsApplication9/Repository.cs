using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    public static class Repository
    {
       static  List<User> Users;
        static Repository()
        {
            Users = new List<User>(); 
        }

        public static void AddNewUser(User user)
        {
            var userNs = (from p in Users where p.Login.Length > 5 orderby p.Login descending select new { p.Name }).ToList();

            var NameA = (from f in userNs where f.Name.StartsWith("A") select f);
                     
            List<User> fff = Users.Where(d => d.Login.Length > 6).OrderByDescending(p => p.Login).ToList();

        }

        public static bool UpdateUser(User user)
        {
            User userN = Users.FirstOrDefault(p => p.Login == user.Login);
            if (userN == null)
            {
                return false;
            }
            else
            {
                userN.Pas = user.Pas;
                return true;
            }

        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Pas { get; set; }
     }
}
