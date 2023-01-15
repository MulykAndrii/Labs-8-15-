using System;
using _003__task.SwapMethod;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();

        var input = Console.ReadLine();
        while (input.ToLower() != "stop")
        {
            list.Add(input);
            input = Console.ReadLine();
        }

        foreach (string element in list)
        {
            Console.WriteLine(element);
        }

        var indexOne = int.Parse(Console.ReadLine());
        var indexTwo = int.Parse(Console.ReadLine());

        var elementOne = list.ElementAt(indexOne);
        var elementTwo = list.ElementAt(indexTwo);

        Console.WriteLine($"Before swapping: Element 1 = {elementOne}, Element 2 = {elementTwo}");
        SwapMethod.Swaping(ref elementOne, ref elementTwo);
        Console.WriteLine($"After swapping:  Element 1 = {elementOne}, Element 2 = {elementTwo}");


        Console.ReadLine();
    }
}
