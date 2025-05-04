using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class User
    {
        public required string UserName { get; set; }
        public required string Email { get; set; }
        private string? _password;
        public void SetPassword(string newPassword)
        {
            _password = newPassword;
        }
        public bool Authenticate(string inputPassword)
        {
            if (_password != inputPassword) {
                Console.WriteLine("Вхід не вдався");
                return false;
            }
            Console.WriteLine("Вхід успішний");
            return true;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Ім'я: " + UserName + " Email: " + Email + " Роль: Користувач");
        }

    }
    class Admin : User
    {
        public void BlockUser(User user)
        {
            Console.WriteLine("Користувача " + user.UserName + " заблоковано");
        }
        public override void DisplayInfo() {
            Console.WriteLine("Ім'я: " + UserName + " Email: " + Email + " Роль: Адміністратор");
        }
    }
    class Moderator : User
    {
        public void ModerateContent()
        {
            Console.WriteLine("Контент модеровано");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Ім'я: " + UserName + " Email: " + Email + " Роль: Модератор");

        }
    }
    class RegularUser : User
    {
        public void PostComment()
        {
            Console.WriteLine("Коментарь опубліковано");

        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Ім'я: " + UserName + " Email: " + Email + " Роль: Звичайний користувач");

        }
    }
}
