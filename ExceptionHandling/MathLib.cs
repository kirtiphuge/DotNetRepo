using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_ExceptionHandling
{
    class MathLib
    {
        
        public int result;
        public int add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public int sub(int a, int b)
        {
            result = a - b;
            return result;
        }
    
    }
}
