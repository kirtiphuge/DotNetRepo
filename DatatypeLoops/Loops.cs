using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DatatypeLoops
{
    class Loops
    {
        public void printNumber()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<2;i++)
            {
                Console.WriteLine("{0}{0}{0}{0}",number, number, number, number);
                Console.WriteLine("{0} {0} {0} {0}",number, number, number, number);
            }

            Console.ReadLine();
        }

        public void printRectangle()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number, number);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} {0}", number, number);
                
            }
            Console.WriteLine("{0}{0}{0}", number, number);
            Console.ReadLine();
        }

        public void ConvertCelToFar()
        {
            int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            celsius = Convert.ToInt32(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);
            Console.ReadLine();
        }

        public void LongWord()
        {
            Console.WriteLine("Enter Statement");
            String text = Convert.ToString(Console.ReadLine());

            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";

            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);


        }

        public void SumOfPrimeNumbers()
        {
            Console.WriteLine("Sum of First 500 Prime Numbers");

            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum.ToString());
        }

        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public void SumOfDigits()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum=0, r;
            while (number != 0)
            {
                r = number % 10;
                number = number / 10;
                sum = sum + r;
            }

            Console.WriteLine("Sum of Digits of Number" + sum);

        }

        public void ReverseSentence()
        {
            Console.WriteLine("Enter Statement");
            string text = Console.ReadLine();
           
            string[] a = text.Split(' ');
            Array.Reverse(a);

            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]+"");
            }
        }

        public void FindLeap()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());

            if((year%4==0 || year%400 == 0) && year%100!=0 )
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }

        public void FindLargestNumber()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("First number is largest");
            }else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("Second number is largest");
            }
            else
            {
                Console.WriteLine("Third number is largest");
            }

        }

        public void TempRange()
        {
            int temp;
            Console.WriteLine("Enter the Temperature in Centigrade : ");
            temp = Convert.ToInt32(Console.ReadLine());

            if(temp<0)
            {
                Console.WriteLine("Freezing Weather");
            }else if(temp>=0 && temp<=10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Very Hot");
            }
        }


        public void TestAlphabet()
        {
            Console.WriteLine("Enter Alphabet");
            string ch = Console.ReadLine();

            if(ch == "a" || ch == "e" || ch == "i" || ch == "o"  || ch =="u")
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Not a Vowel");
            }
        }

        public void Calculator()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Exit");

            Console.WriteLine("Input your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int add = num1 + num2;
                    Console.WriteLine("Addition = {0}",add);
                    break;
                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine("Subtraction = {0}", sub);
                    break;
                case 3:
                    int mul = num1 * num2;
                    Console.WriteLine("Multiplication = {0}", mul);
                    break;
                case 4:
                    int div = num1 / num2;
                    Console.WriteLine("Division = {0}", div);
                    break;

                case 5: return;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }


        public void triangle()
        {
           
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int row = width; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write(number);
                }

                Console.WriteLine();
            }
        }

        public void CalCube()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=number;i++)
            {
                Console.WriteLine("Number is {0} and cube of {0} is {1}", i, (i * i * i));
            }
        }

        public void ConvertDecToBin()
        {
            int num, i, j, binno = 0, dn;
            Console.Write("Enter a number to convert : ");
            num = Convert.ToInt32(Console.ReadLine());
            dn = num;
            i = 1;
            for (j = num; j > 0; j = j / 2)
            {
                binno = binno + (num % 2) * i;
                i = i * 10;
                num = num / 2;
            }

            Console.Write("\nThe Binary of {0} is {1}.\n\n", dn, binno);
        }

        public void PrintDiamond()
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        public void NumberPyramid()
        {
            int num, space;

           
                Console.Write("Enter a number between 1 to 9 : ");

                num = Convert.ToInt32(Console.ReadLine());

                space = num - 1;

                for (int i = 1; i <= num; i++)
                {
                    for (space = 1; space <= (num - i); space++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }

                    for (int k = (i - 1); k >= 1; k--)
                    {
                        Console.Write(k);
                    }

                    Console.WriteLine();

                }
            
        }
    }

}
