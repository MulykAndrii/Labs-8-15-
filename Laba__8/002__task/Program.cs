using System;
using System.Linq;
using _001__task.Box;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        while(input.ToLower() != "stop")
        {
            if (input.All(Char.IsLetter) || input.All(Char.IsSymbol))
            {
                var box = new Box<string>(input);
                Console.WriteLine(box);
            }
            else if (input.All(Char.IsDigit) || input.All(Char.IsNumber))
            {
                var box = new Box<int>(int.Parse(input));
                Console.WriteLine(box);
            }
            else
            {
                var box = new Box<object>(input);
                Console.WriteLine(box);
            }

            
            input = Console.ReadLine();
        }


        Console.ReadLine();
    }
}
