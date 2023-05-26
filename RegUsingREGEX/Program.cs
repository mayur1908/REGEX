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
            //  user to enter a last name
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            //  regular expression pattern
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Match the last name against the pattern
            Match match = regex.Match(lastName);

            // Check if the last name is valid
            if (match.Success)
            {
                Console.WriteLine("Valid last name!");
            }
            else
            {
                Console.WriteLine("Invalid last name. Last name should start with a capital letter and have a minimum of 3 characters.");
            }
        }
    }
}
