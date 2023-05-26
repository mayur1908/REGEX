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
            string phoneNumber = "91 9637003670"; // Example phone number in the specified format

            string pattern = @"^\d{2}\s\d{10}$"; // Regular expression pattern to match the format

            bool isValid = Regex.IsMatch(phoneNumber, pattern); // Check if the phone number matches the pattern

            if (isValid)
            {
                Console.WriteLine("Phone number is valid.");
            }
            else
            {
                Console.WriteLine("Phone number is invalid.");
            }
        }
    }
}
