using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day15_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 10;
            int num2 = 0;
            int result =0;

            try
            {
                result = num1 / num2;
                result = num1 / 10;
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception {0}", e);
            }
            finally
            {
                Console.WriteLine("Result : {0}", result);
            }*/

            Temperature t1 = new Temperature();
            t1.showTemp();
            MathLib m=null;
            try {
                int res;
               // m.sub(10, 20);
                Console.WriteLine("Enter no 1");
                int num1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter no 2");
                int num2 = Convert.ToInt16(Console.ReadLine());


                res = m.add(num1, num2);
                Console.WriteLine("1.ADDITION : {0}", res);

                res = m.sub(num1, num2);
                Console.WriteLine("2.SUBTRACTION : {0}", res);


           }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }

            catch(ArgumentException e)
            {
                Console.WriteLine(e);
            }

            catch(FormatException e)
            {
                Console.WriteLine("Exception :{0},Method NAme : {1}",e,(e.TargetSite).Name);
            }

            bool flag = true;
            try
            {
                IConvertible conv = flag;
                Char ch = conv.ToChar(null);
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException )
            {
                Console.WriteLine("Cannot convert a Boolean to a Char.");
            }

            try
            {
                Char ch = Convert.ToChar(flag);
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Cannot convert a Boolean to a Char.");
            }
            Console.ReadLine();
        }
    }
}
