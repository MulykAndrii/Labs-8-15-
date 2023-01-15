using System;
using System.Text;

namespace _008__task.Tuple
{
    internal class Tupple<T, K>
    {
        private T FirstElement;
        private K SecondElement;
        public Tupple(T First, K Second)
        {
            this.FirstElement = First;
            this.SecondElement = Second;
        }
        public override string ToString()
        {
            var Builder = new StringBuilder();
            Builder.AppendLine($"The Fisrt element: {this.FirstElement.ToString()} and the Second element: {this.SecondElement.ToString()}");
            return Builder.ToString();
        }
    }
}
