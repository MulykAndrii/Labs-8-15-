using System;
using System.Collections.Generic;
using System.Linq;

namespace _003__task.SwapMethod
{
    static class SwapMethod
    { 
        public static void Swaping<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
