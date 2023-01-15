using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> notebook = new SortedDictionary<string, string>();

            string collections = Console.ReadLine();


            while (true)
            {
                if (collections.ToUpper() == "END")
                {
                    break;
                }
                else
                {
                    string[] contacts = collections.Split();

                    if (contacts[0].ToUpper() == "A")
                    {
                        if (notebook.ContainsKey(contacts[1]))
                        {
                            notebook[contacts[1]] = contacts[2];
                        }
                        else
                        {
                            notebook.Add(contacts[1], contacts[2]);
                        }
                    }
                    else if (contacts[0].ToUpper() == "S")
                    {
                        if (notebook.ContainsKey(contacts[1]))
                        {
                            Console.WriteLine($"The Person: {contacts[1]} has mobile {notebook[contacts[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"The Person: {contacts[1]} does not exist.");
                        }
                    }
                    else
                    {
                        foreach (var contact in notebook)
                        {
                            Console.WriteLine(contact.Key + " -->> " + contact.Value);
                        }
                    }

                    collections = Console.ReadLine();
                }
            }


            Console.ReadLine();
        }
    }
}
