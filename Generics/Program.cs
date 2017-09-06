using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapGenerics<int> s1 = new SwapGenerics<int>();
            SwapGenerics<string> s2 = new SwapGenerics<string>();
            s1.Swap(10, 20);
            s2.Swap("A", "B");

            Console.ReadLine();
        }
    }
}
