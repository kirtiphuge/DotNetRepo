using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_partial_classes
{
    static class ExtensionMethod
    {
        public static int MultiplyBy(this int value, int mulitiplier)
        {
            
            return value * mulitiplier;
        }
    }
}
