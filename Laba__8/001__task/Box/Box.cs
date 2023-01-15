using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001__task.Box
{
    internal class Box<T>
    {
        private T _value;
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get => this._value;
            set => this._value = value;
        }
        public override string ToString()
        {
            var Builder = new StringBuilder();
            Builder.AppendLine($"The full name of the object is {this.Value.GetType().FullName} and it has value: {this.Value}");
            return Builder.ToString();
        }
    }
}
