using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quiz.Controllers
{
    internal class Validate
    {
        public static string isName(string name)
        {
            bool result = !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[A-Za-z ]+$");
            return result ? "" : "Invalid Name\n";
        }

        public static string isEmail(string email)
        {
            bool result = !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^[a-zA-Z0-9._]+@[a-zA-Z0-9.]+\.[a-zA-Z]{2,}$");
            return result ? "" : "Invalid E-Mail\n";
        }

        public static string isPhone(string phone)
        {
            bool result = !string.IsNullOrWhiteSpace(phone) && Regex.IsMatch(phone, @"^\d{5,10}$");
            return result ? "" : "Invalid Phone No.\n";
        }

        public static string isPassword(string password)
        {
            bool result = !string.IsNullOrWhiteSpace(password) && Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).+$");
            return result ? "" : "Invalid Password.\n\nPassword should contain:\nUpper Case | Lower Case | Digits";
        }
    }
}
