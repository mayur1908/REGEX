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
            string password = "password123";

            // Create a regular expression pattern to match at least one uppercase letter
            string pattern = @"[A-Z]";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Matches method to find all matches in the password string
            MatchCollection matches = regex.Matches(password);

            // Check if at least one match is found
            if (matches.Count > 0)
            {
                Console.WriteLine("Password meets the Rule 2 requirement.");
            }
            else
            {
                Console.WriteLine("Password does not meet the Rule 2 requirement.");
            }
        }
    }
}
