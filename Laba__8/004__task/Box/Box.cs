using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _004__task.Box
{
    internal class Box<T> where T : IComparable
    {
        List<T> list;
        public Box()
        {
            list = new List<T>();  
        }
        public void AddElement(T element)
        {
            try 
            {
                list.Add(element);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int GetComparable(T value) 
        {
            int result = 0;
            foreach(T element in list)
            {
                if (value.CompareTo(element) < 0)
                    result++;
            }
            return result;
        }

        public override string ToString()
        {
            var Builder = new StringBuilder();
            foreach (T element in list)
            {
                Builder.AppendLine($"The element is {element}");
            }

            return Builder.ToString();
        }
    }
}
