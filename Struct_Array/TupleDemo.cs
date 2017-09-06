using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Struct_Array
{
    class TupleDemo
    { public void DisplayTuple()
        {
            Tuple<int, string, DateTime> t1 = Tuple.Create(1, "kittu", new DateTime(1995, 11, 21));

            Console.WriteLine("Student with ID {0} name {1} and Birth date {2}", t1.Item1, t1.Item2, t1.Item3);

            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine("\nNested Tuple ");

            var e = new Tuple<int, int, int, int, int, int, int, Tuple<double, double, double>>(2, 4, 6, 8, 10, 12, 14, Tuple.Create(1.1, 1.2, 1.3));
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", e.Item1, e.Item2, e.Item3, e.Item4, e.Item5, e.Item6,e.Item7,e.Rest.Item1,e.Rest.Item2,e.Rest.Item3);


        }


    }
}
