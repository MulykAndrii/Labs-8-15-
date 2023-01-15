using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _009__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string collections = " james smith, tomas frank, bob salivan";
            char[] separators = { ',', '.' };
            string[] strings = collections.Split(separators);

            TextInfo inforamtion = CultureInfo.CurrentCulture.TextInfo;
            foreach (string sentense in strings)
            {
                Console.WriteLine(sentense + " ---> " + inforamtion.ToTitleCase(sentense));
            }


            Console.ReadLine();
        }
    }
}
