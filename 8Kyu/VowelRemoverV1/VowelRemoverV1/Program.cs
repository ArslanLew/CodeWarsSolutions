using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelRemoverV1
{
    class Program
    {
        //Create a function called shortcut to remove all the lowercase vowels in a given string.
        static void Main(string[] args)
        {
            Console.WriteLine(Shortcut(Console.ReadLine()));
            Console.ReadKey(true);
        }


        public static string Shortcut(string input)
        {
            string str = input;
            string[] vowels = { "a", "e", "i", "o", "u" };
            foreach (string vowel in vowels)
            {
                input = input.Replace(vowel, "");
            }
            return input;
        }
    }
}
