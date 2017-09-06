using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalVar;
using Demo.sub;

namespace Day3_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            global::System.Console.WriteLine();     //use System defined Console class
            GlobalVar.Console g = new GlobalVar.Console();    // use the Custom class defined
            g.WriteLine();
            

            Demo.sub.Demo1 d1 = new Demo.sub.Demo1();
            d1.Print();

            global::System.Console.ReadLine();
        }
    }
}

namespace GlobalVar
{
    class Console
    {
        public void WriteLine()
        {
            System.Console.WriteLine("Custom Class");
        }
    }
}

namespace Demo
{
    namespace sub
    {
        class Demo1
        {
            public void Print()
            {
                System.Console.WriteLine("Nested namespace");
            }
        }
    }
}
