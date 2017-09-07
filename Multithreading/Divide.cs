using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day17_Multithreading
{
    class Divide
    {
        int num1, num2;
        int result;
        public void divide()
        {
            
            Random o = new Random();
            Monitor.Enter(this);
            for(long i=0;i<1000000;i++)
            {
                num1 = o.Next(1,50);
                num2 = o.Next(1,51);
                result = num1 / num2;
                Console.WriteLine(result);
                num1 = 0;
                num2 = 0;
            }
            Monitor.Exit(this);
            
        }
    }
}
