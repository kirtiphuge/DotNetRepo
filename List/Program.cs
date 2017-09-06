using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();

            Employee e1 = new Employee(101, "Kirti", 100000);
            Employee e2 = new Employee(102, "Kirti", 10000);
            Employee e3 = new Employee(103, "Kirti", 20000);
            Employee e4 = new Employee(104, "Kirti", 300000);
            Employee e5 = new Employee(105, "Kirti", 100000);
            li.Add(e1);
            li.Add(e2);
            li.Add(e3);
            li.Add(e4);
            li.Add(e5);

            foreach (Employee o in li.OrderBy(e=>e.salary))
            {
                //Console.Write("\t"+o.ID);
                //Console.Write("\t"+o.name);
                //Console.Write("\t"+o.dept_name);
                Console.WriteLine(o);
            }



            Console.ReadLine();
        }
    }
}
