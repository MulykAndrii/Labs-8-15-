using System;
using _004__task.Box;

class Program
{
    static void Main()
    {
        var box = new Box<string>();
        box.AddElement("aaa");
        box.AddElement("bb");
        box.AddElement("cc");
        box.AddElement("aa");
        Console.WriteLine(box);


        Console.WriteLine(box.GetComparable("aa"));

        Console.ReadLine();
    }
}
