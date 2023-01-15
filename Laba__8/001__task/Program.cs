using _001__task.Box;
using System;

class Program
{
    static void Main()
    {
        var boxString = new Box<string>("Hello, Bob");
        Console.WriteLine(boxString);

        var boxInt = new Box<int>(2022);
        Console.WriteLine(boxInt);

        Console.ReadLine();
    }
}