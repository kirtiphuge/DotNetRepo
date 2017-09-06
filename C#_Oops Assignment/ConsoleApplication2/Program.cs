using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;
namespace OOPs
{
  class Program
    {
        static void Main(String[] args)
        {
           Dog mydog = new Dog();
           clsAbstarct thePet = mydog;
           thePet.eat();
           mydog.sound();
           Console.WriteLine("Success");

            //Car mycar = new Car();
           // mycar.CarType();
            //Console.ReadLine();

            Calculator o1 =new Calculator();
            o1.sum();
            o1.sum(1, 5);
            o1.sum("kittu");

            DerivedClass d1 = new DerivedClass();
            //BaseClass b1 = d1;
            d1.MyMethod();

            BaseClass b1 = new BaseClass();
           
            b1.MyMethod();
            Console.ReadLine();


        }
    }
}


