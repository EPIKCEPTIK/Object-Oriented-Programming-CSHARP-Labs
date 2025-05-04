
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            
            List<User> users = new List<User>
                {
                    new Admin { UserName = "AdminUser", Email = "admin@example.com" },
                    new Moderator { UserName = "ModUser", Email = "mod@example.com" },
                    new RegularUser { UserName = "RegUser", Email = "user@example.com" },
                };


            foreach (User user in users)
            {
                user.DisplayInfo();
            }
            foreach (var user in users)
            {
                user.SetPassword("123");
            }
            foreach (var user in users)
            {
                user.Authenticate("1234");
            }
            foreach (User user in users)
            {
                if (user is Admin admin)
                {
                    admin.BlockUser(new RegularUser { UserName = "AnotherUser", Email = "another@example.com" });
                }
                else if (user is Moderator moderator)
                {
                    moderator.ModerateContent();
                }
                else if (user is RegularUser regularUser)
                {
                    regularUser.PostComment();
                }
            }

        }
    }
}
