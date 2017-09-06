using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_partial_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.DoWork();
            //e1.DoWork("kittu");

            // static_class.calArea(5);
            //int result = 10.MultiplyBy(2);
            //Console.WriteLine(result);

            IEmployee e1 = new Employee_class();
            

            IEmployee e2 = new FullTimeEmployee_class();

            Demo d1 = new Demo();
            d1.DontKnow(e1);
            d1.DontKnow(e2);

            Console.ReadLine();

            
        }
    }
}
