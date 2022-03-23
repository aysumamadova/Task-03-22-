using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace IAccount_task.Models
{
    public class User
    {
        public static string Id = "^[0-9]{1,}$";
        public static string Fullname = "^([a-zA-Z]{3,})$";
        public static string Email = @"^([^\W])([a-z\d\.\-_]+)@([a-z\d\-]+\.)([a-z]{2,13})$";
        public static string Password = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])+[a-zA-z0-9]{8,}$";

        public bool IdCheckher()
        {
            return Regex.IsMatch("1234", Id);
        }
        public bool FullnameCheckher()
        {
            return Regex.IsMatch("Aysou", Fullname);
        }
        public bool EmailCheckher()
        {
            return Regex.IsMatch("aysumamedova26@gmail.com", Email);
        }
        public bool PasswordCheckher()
        {
            return Regex.IsMatch("A7a7952323332", Password);
        }



    }
}
