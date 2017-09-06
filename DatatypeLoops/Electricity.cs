using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DatatypeLoops
{
    class Electricity
    {
        string name;
        int custid, units;
        double amount;

        public void CalElectricityBill()
        {
            Console.WriteLine("Enter Customer Name");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Customer Id");
            custid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Units Consumed");
            units = Convert.ToInt32(Console.ReadLine());

            if(units>=0 && units<200)
            {
                amount = units * 1.20;
            }else if(units>=200 && units <400)
            {
                amount = units * 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                amount = units * 1.80;
            }else
            {
                amount = units * 2.0;
            }

            if(amount>=400)
            {
                double add = (15 * amount) / 100;
                amount=amount + add;
            }

            if(amount<=100)
            {
                Console.WriteLine("Minimum Bill Amount should be greater than 100");
            }

            Console.WriteLine("Name :{0}", name);
            Console.WriteLine("Customer Id :{0}", custid);
            Console.WriteLine("Electricity Bill :{0}", amount);
        }
    }
}
