using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Calculator
    {
        public void sum()
        {
            Console.WriteLine("No value");
        }

        public void sum(int x,int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}",x,y,(x+y));
        }

        public void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }

        public void sum(string s)
        {
            Console.WriteLine("String is {0}",s);
        }
    }
}
