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
            // Input string to check
            string input = "Hello@World";

            // Regular expression pattern
            string pattern = @"^[A-Za-z0-9]*[@#$%^&+=]$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch() method to check if the input matches the pattern
            bool hasOneSpecialChar = regex.IsMatch(input);

            // Print the result
            Console.WriteLine("Input string: " + input);
            Console.WriteLine("Has exactly one special character: " + hasOneSpecialChar);
        }
    }
}