using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_List
{
    public class Employee
    {
        public string name;
        public int empcode;
        public int salary;

        public Employee(int _id,string _name,int _sal)
        {
            empcode = _id;
            name = _name;
            salary = _sal;
        }

        public override string ToString()
        {
            return "Person: " + empcode + " " + name + " " + salary;
        }
    }
}
