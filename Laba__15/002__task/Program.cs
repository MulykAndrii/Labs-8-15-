using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string collections = "Some strings for this task-example! And we can see the result!";

            if (collections.Length < 20) collections = new string(collections.PadRight(20, '*').ToArray());
            else collections = new string(collections.Substring(0, 20).ToArray());

            Console.WriteLine(collections);

            Console.ReadLine();
        }
    }
}
