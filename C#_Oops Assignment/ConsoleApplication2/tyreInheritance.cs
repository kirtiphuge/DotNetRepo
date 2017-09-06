using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{

    public class tyreInheritance
    {
        public void tireMethod()
        {
            Console.WriteLine("Main Class");
        }
    }


    public class Scooter : tyreInheritance
    {
           public void ScooterType()
        {
            Console.WriteLine("Scooter is red");
           tireMethod();
        }
    }


    public class Car : tyreInheritance
    {
        public void CarType()
        {
            Console.WriteLine("Car color is blue");
            tireMethod();
        }
    }
}
