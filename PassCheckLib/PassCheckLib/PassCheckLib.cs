using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PassCheckLib
{
    public class PasswordCheckClass
    {
        public string passLengthCheck(string password)
        {
            string result;

            if (password.Length >= 8)
            {
                Console.WriteLine("Достаточная длина пароля");
                return result = "ok";
            }
            else
            {
                Console.WriteLine("Не достаточная длина пароля");
                return result = "not ok";
            }
        }

        public string passCheck(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,32}$");
            string result;

            if (regex.IsMatch(password))
            {
                Console.WriteLine("Надежный пароль");
                return result = "Надежный пароль";
            }
            else
            {
                Console.WriteLine("ненадежный пароль");
                return result = "ненадежный пароль";
            }
        }
    }
}
