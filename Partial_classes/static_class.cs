using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_partial_classes
{
    static class static_class
    {
        static double pi = 3.14;

        public static void calArea(int r)
        {
            double area = pi * r * r;
            Console.WriteLine("Area of Circle is :"+area);
        }
    }
}
