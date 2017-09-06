using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_partial_classes
{
    public class A
    {
        public void Display()
        {

            Console.WriteLine("Display A");
        }
    }
    public class B : A
    {
        public new void Display()
        {

            Console.WriteLine("Display B");
        }
    }

    public class Try
    {

        static void Main(string[] args)
        {
            A a = new B();
            a.Display();
            Console.ReadKey();
        }
    }
}
