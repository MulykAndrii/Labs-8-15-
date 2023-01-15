using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string collections = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            char[] separators = { '.', ' ', '?', '!', ',', ':' };

            string[] strings = collections.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentense in strings)
            {
                if (sentense.SequenceEqual(sentense.Reverse()))
                {
                    Console.WriteLine(sentense);
                }
            }

            Console.ReadLine();
        }
    }
}
