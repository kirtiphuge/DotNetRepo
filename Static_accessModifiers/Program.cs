using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_static_accessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaMaster a1 = new AreaMaster(1, "IND", "INDIA", "Anything", AreaType.country, 0);
            a1.addToList(a1);
            AreaMaster a2 = new AreaMaster(2, "MH", "MAHARASHTRA", "Anything", AreaType.state, 1);
            a2.addToList(a2);
            AreaMaster a3 = new AreaMaster(3, "PUN", "PUNE", "Anything", AreaType.city, 2);
            a3.addToList(a3);
            AreaMaster a4 = new AreaMaster(4, "PUN-D", "PUNE DISTRICT", "Anything", AreaType.district, 3);
            a4.addToList(a4);
            AreaMaster a5 = new AreaMaster(5, "MU", "MUMBAI", "Anything", AreaType.city, 2);
            a5.addToList(a5);

            Console.WriteLine("Enter your search category : \n1.By Country\n2.By State\n3.By City\n4.By District");
            int ch = Convert.ToInt16(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    countryMaster c = new countryMaster();
                    Console.WriteLine("Enter Country");
                    string s = Convert.ToString(Console.ReadLine());
                    c.GetAreaMasterByCountry(s);

                    break;
                case 2:
                    stateMaster st = new stateMaster();
                    Console.WriteLine("Enter State");
                    string s1 = Convert.ToString(Console.ReadLine());
                    st.GetAreaMasterByState(s1);
                    break;

                case 3:
                    cityMaster ct = new cityMaster();
                    Console.WriteLine("Enter City");
                    string s2 = Convert.ToString(Console.ReadLine());
                    ct.GetAreaMasterByCity(s2);
                    break;

                case 4:
                    districtMaster dt = new districtMaster();
                    Console.WriteLine("Enter District");
                    string s3 = Convert.ToString(Console.ReadLine());
                    dt.GetAreaMasterByDistrict(s3);
                    break;
            }

            Console.ReadLine();

        }
    }
}
