using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_partial_classes
{
    interface IEmployee
    {
        void CalSal();
        void show();
    }
    class Employee_class : IEmployee
    {
        public void CalSal()
        {
            double sal = 10000;
            Console.WriteLine("Employee Salary :"+sal);
        }

        public void show()
        {
            Console.WriteLine("Done");
        }
    }

    class FullTimeEmployee_class : IEmployee
    {
        public void CalSal()
        {
            double sal = 50000;
            Console.WriteLine("Full Time Employee Salary :" + sal);
        }

        public void show()
        {
            Console.WriteLine("Done");
        }
    }

    class Demo
    {
       public void DontKnow(IEmployee obj)
        {
            obj.CalSal();
            obj.show();
        }
    }
}
