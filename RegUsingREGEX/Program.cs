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
            string emailSamples = "example1@example.com, example2@example.com, example3@example.com";

            // Step 1: Define a regular expression pattern to match email addresses.
            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            // Step 2: Create a Regex object using the pattern.
            Regex regex = new Regex(pattern);

            // Step 3: Use the Regex object to find all matches in the emailSamples string.
            MatchCollection matches = regex.Matches(emailSamples);

            // Step 4: Create an empty string to store the cleared email samples.
            string clearedEmailSamples = "";

            // Step 5: Iterate over each match and add it to the clearedEmailSamples string.
            foreach (Match match in matches)
            {
                clearedEmailSamples += match.Value + ", ";
            }

            // Step 6: Remove the trailing comma and space from the clearedEmailSamples string.
            clearedEmailSamples = clearedEmailSamples.TrimEnd(',', ' ');

            // Step 7: Output the cleared email samples.
            Console.WriteLine("Cleared email samples:");
            Console.WriteLine(clearedEmailSamples);
        }
    }
}