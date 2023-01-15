using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _007__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string collections = "Welcome to the <upcase>Software University</upcase>. Learn <upcase>computer " +
                "programming</upcase> and start a <upcase>job</upcase> in a software company.";

            Dictionary<string, string> replacements = new Dictionary<string, string>() { {"<upcase>", ""}, {"</upcase>", ""} };
            collections = Regex.Replace(collections, @"(?<=<upcase>)(.*?)(?=<\/upcase>)", x => x.Value.ToUpper(), RegexOptions.IgnoreCase);
            collections = replacements.Aggregate(collections, (current, replacement) => current.Replace(replacement.Key, replacement.Value));

            Console.WriteLine(collections);

            Console.ReadLine();
        }
    }
}
