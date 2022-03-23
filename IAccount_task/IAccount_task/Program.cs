using System;
using IAccount_task.Models;

namespace IAccount_task
{
    class Program
    {
        static void Main(string[] args)
        {
            User Regex = new User();

            bool Id = Regex.IdCheckher();
            bool Fullname = Regex.FullnameCheckher();
            bool Email = Regex.EmailCheckher();
            bool Password = Regex.PasswordCheckher();

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fullname: { Fullname}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password {Password}");
        }
    }
}
