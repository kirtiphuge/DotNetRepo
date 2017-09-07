using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Multithreading
{
    public class MultiThreading
    {   static int a = 10;
        static int b = 20;
         

        public static void Fuc1()
        {
            int ans;
            ans = a + b;
            Console.WriteLine("ADDITION : {0} + {1} = {2}", a, b, ans);
        }

        public void Func2(Object p)
        {
            int a = 10, b = 10, ans = 0;
            Console.WriteLine("SUBTRACTION : {0} - {1} = {2}", a, b, ans);
        }
    }
}
