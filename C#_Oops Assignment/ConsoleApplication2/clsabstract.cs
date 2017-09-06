using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract class clsAbstarct
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Animal can sound");
           
        }
    }


    class Dog : clsAbstarct
    {
        public override void eat()
        {
            Console.WriteLine("dog can eat");
            
        }
    }

}
