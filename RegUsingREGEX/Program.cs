using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegUsingREGEX
{
    public class Program
    {
        static void Main()
        {
            string password = "MyPassw0rd"; // Example password

            bool isPasswordValid = ValidatePassword(password);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid.");
            }
        }

        static bool ValidatePassword(string password)
        {
            string pattern = @"\d"; // Regex pattern to match a numeric digit
            Match match = Regex.Match(password, pattern); // Check if the password contains a numeric digit

            if (match.Success)
            {
                return true; // The password contains at least one numeric digit
            }
            else
            {
                return false; // The password does not contain a numeric digit
            }
        }
    }
}