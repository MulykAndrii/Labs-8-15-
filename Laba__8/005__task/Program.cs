using System;
using _004__task.Box;

class Program
{
    static void Main()
    {
        var box = new Box<double>();
        box.AddElement(20.52);
        box.AddElement(15);
        box.AddElement(41.25);
        box.AddElement(58.00);
        box.AddElement(27);
        Console.WriteLine(box);


        Console.WriteLine(box.GetComparable(25));

        Console.ReadLine();
    }
}
