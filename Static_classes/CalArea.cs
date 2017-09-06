using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignments
{
    static class CalArea
    {   static int area;

        public static void cal(int len,int b)
        {
            area = len * b;
            Console.WriteLine("Area of Rectangle is :"+area);
        }

    }
}
