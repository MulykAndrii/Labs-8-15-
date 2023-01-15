using System;
using _006__task.Own_List;

class Program
{
    static void Main(string[] args)
    {
        string[] menuItems = new string[] { "Creatin List", "Remove element by index", "Find the maximum number", "Find the minimum number" 
        , "Find element by index"};

        Console.WriteLine("Menu List");
        Console.WriteLine();

        MyList<int> list = new MyList<int>();
        int row = Console.CursorTop;
        int col = Console.CursorLeft;
        int index = 0;
        while (true)
        {
            DrawMenu(menuItems, row, col, index);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (index < menuItems.Length - 1)
                        index++;
                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        index--;
                    break;
                case ConsoleKey.Enter:
                    switch (index)
                    {
                        case 0:
                            Random random = new Random();
                            for (int i = 0; i < 10; i++)
                            {
                                list.AddElement(random.Next(10));
                            }
                            Console.WriteLine("The list of numbers between 0 and 10: ");
                            Console.WriteLine(list);
                            break;

                        case 1:
                            Console.Write("\n\n\nEnter the index of element: ");
                            var indexElement = int.Parse(Console.ReadLine());
                            list.RemoverElement(indexElement);
                            Console.WriteLine(list);
                            break;

                        case 2:
                            Console.WriteLine("\n\n\n\n\n");
                            Console.WriteLine(list.MaxElement());
                            break;

                        case 3:
                            Console.WriteLine("\n\n\n\n\n\n\n");
                            Console.WriteLine(list.MixElement());
                            break;

                        case 4:
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                            Console.Write("Enter element which you want to find: ");
                            var indexFind = int.Parse(Console.ReadLine());
                            Console.WriteLine(list.FindElement(indexFind));
                            break;

                        case 5:
                            Console.WriteLine("Exit from application");
                            return;
                    }
                    break;
            }
        }
    }

    private static void DrawMenu(string[] items, int row, int col, int index)
    {
        Console.SetCursorPosition(col, row);
        for (int i = 0; i < items.Length; i++)
        {
            if (i == index)
            {
                Console.BackgroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(items[i]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
