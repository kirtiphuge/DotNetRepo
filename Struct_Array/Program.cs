using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Struct_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Single s1 = new Single();
            s1.print(20);

            MultiDim s2 = new MultiDim();
            s2.print();

            jaggedArray s3 = new jaggedArray();
            s3.print();

            TupleDemo t = new TupleDemo();
            t.DisplayTuple();

            CoOrds c = new CoOrds(10,10);
            Console.Write("\n\nCoOrds 1: ");
            Console.WriteLine("x = {0}, y = {1}", c.x, c.y);

            CoOrds c2 = c;
            c2.x = 20;c2.y = 30;
            Console.Write("\n\nCoOrds 1: ");
            Console.WriteLine("x = {0}, y = {1}", c2.x, c2.y);

            Single ss = s1;
            //ss.temp = 10;
            ss.print(10);
            Console.ReadLine();
        }
    }
}
