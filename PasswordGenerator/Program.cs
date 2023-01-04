using System;
using System.Linq;

namespace PasswordGenerator
{
    public class Program
    {
        private static Random random = new Random();        // This makes use of the framworks random-feature, this makes it possible to make random arrangements in the passwordgenerator.

        public static string RandomChar(int Passlength)     // This method returns a string with a length of choice - because of the Passlength int.
        {
            string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890";     // The string chars includes both capital and normal letters, all the numbers and the most frequent symbols.
            return new string(Enumerable.Repeat(chars, Passlength).Select(s => s[random.Next(s.Length)]).ToArray());    // This line runs trough the char-string, based on the length of choice, until all spaces in Passlength has been filled.
        }

        public static string RandomSymb(int length) 
        {
            string symbols = "!@#&?";
            return new string(Enumerable.Repeat(symbols, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RandomChar(7)+RandomSymb(1));
        }
    }
}
