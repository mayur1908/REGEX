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
            //user to enter their first name
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            // regex pattern for validating the first name
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Create a regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the regex object to match the first name
            Match match = regex.Match(firstName);

            // Check if the first name matches the pattern
            if (match.Success)
            {
                Console.WriteLine("Valid first name!");
            }
            else
            {
                Console.WriteLine("Invalid first name. It should start with a capital letter and have at least 3 characters");
            }
        }
    }
}
