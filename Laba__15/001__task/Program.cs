using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001__task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string collections = "Hello! It is me Mario!";

            Console.WriteLine(collections);

            collections = new string(collections.Reverse().ToArray());

            Console.WriteLine(collections);

            Console.ReadLine();
        }
    }
}
