using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day16_ADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s = new Student();
                Console.WriteLine("ALL RECORDS.........................");
                s.Getdata();
                Console.WriteLine("INSERT RECORD......");
                s.SaveData();

               // s.update();
               // s.getDataSet();
                s.delete();
               s.Getdata();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
