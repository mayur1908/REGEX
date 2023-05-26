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
            //user to enter an email address
            Console.WriteLine("Enter an email address:");
            string email = Console.ReadLine();

            //regex pattern for validating the email address
            string pattern = @"^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-]?[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the email matches the pattern
            Match match = regex.Match(email);

            // Check if the email matches the pattern
            if (match.Success)
            {
                Console.WriteLine("Valid email address");
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }
        }
    }
}
