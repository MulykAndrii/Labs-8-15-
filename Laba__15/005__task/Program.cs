using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string collections = "https://www.softuni.bg/Resources/Materials";

            string protocol = collections.Substring(0, collections.IndexOf("://", 0));
            string server = collections.Substring(protocol.Length + 3, collections.IndexOf("/", protocol.Length + 4) - (protocol.Length + 3));
            string resours= collections.Substring((protocol.Length + 3 + server.Length + 1));
            Console.WriteLine($"[Protocol]: {protocol}");
            Console.WriteLine($"[Server]: {server}");
            Console.WriteLine($"[Resours]: {resours}");
            

            Console.ReadLine();
        }
    }
}
