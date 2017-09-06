using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DatatypeLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter Level");
            // int level = Console.Read();

            // PrintPattern p1 = new PrintPattern();
            // p1.PrintStars(level);

            //Console.WriteLine("Enter String");
            //String name = Console.ReadLine();

            //Palindrome p = new Palindrome();
            //p.CheckPalindrome(name);

            Loops l = new Loops();
            Electricity e = new Electricity();

            //l.printNumber();

            //l.printRectangle();

            //l.ConvertCelToFar();

            //l.LongWord();
            //l.SumOfPrimeNumbers();
            //l.SumOfDigits();
            //l.ReverseSentence();
            //l.FindLeap();
            //l.FindLargestNumber();
            //l.TempRange();
            //l.TestAlphabet();
            //e.CalElectricityBill();
            //l.Calculator();  
            // l.triangle();
            //l.CalCube();
            //l.ConvertDecToBin();
            //l.PrintDiamond();
            l.NumberPyramid();
            Console.ReadLine();
                
        }
    }
}
