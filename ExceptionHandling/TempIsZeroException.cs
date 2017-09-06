using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_ExceptionHandling
{
    
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string msg) : base(msg)
        {
            //Console.WriteLine(msg);
        }
    }

    public class Temperature
    {
        
        public void showTemp()
        {
            int temperature = 0;
            string msg = "Zero Temperature Found";
            try
            {
                if (temperature == 0)
                {
                    throw new TempIsZeroException(msg);
                }
                else
                {
                    Console.WriteLine("Temperature is : {0}", temperature);
                }
            }
            catch(TempIsZeroException tempIsZeroException)
            {
                Console.WriteLine(tempIsZeroException.Message);
            }

        }
    }
}
