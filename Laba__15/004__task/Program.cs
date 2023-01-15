using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _004__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string collections = " Welcome to SoftUni! You will learn programming, algorithms, problem solving and software technologies. " +
                "You need to allocate for study 20-30 hours weekly. " +
                "Good luck! I am fan of Motorhead. To be or not to be - that is the question. " +
                "TO DO OR NOT?";

            Console.WriteLine(collections);
            Console.WriteLine(new string('=', 50));

            char[] separators = {'.', '!', '?'};
            string[] result = collections.Split(separators);

            foreach (string sentence in result)
            {
                Console.WriteLine(sentence);
            }

            Console.Write("Enter the special word: ");
            string special = Console.ReadLine();

            foreach (string sentence in result)
            {
                if (Regex.Match(sentence, $@"\b{special}\b").Success)
                {
                    Console.WriteLine(sentence);
                }
            }

            Console.ReadLine(); // Delay
        }
    }
}
