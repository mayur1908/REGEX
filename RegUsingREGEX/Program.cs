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
        static void Main(string[] args)
        {
            // Regular expression pattern to enforce minimum 8 characters
            string pattern = ".{8,}";

            // Test password inputs
            string[] passwords = { "1234567", "password", "securepass", "strongpassword" };

            foreach (string password in passwords)
            {
                // Check if the password matches the pattern
                bool isMatch = Regex.IsMatch(password, pattern);

                Console.WriteLine($"Password: {password}");
                Console.WriteLine($"Meets minimum length requirement: {isMatch}");
                Console.WriteLine();
            }
        }
    }
}
