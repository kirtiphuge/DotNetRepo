using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_partial_classes
{
    
        public partial class Employee
        {
            public void DoWork()
            {
            Console.WriteLine("In Work");
            }
        }

        public partial class Employee
        {
            public void GoToLunch()
            {
            Console.WriteLine("Go to Lunch");
            }

        public void DoWork(string name)          //overloading possible
        {
            Console.WriteLine(name);
        }
    }
    
}
