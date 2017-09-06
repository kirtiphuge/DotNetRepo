using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Struct_Array
{
    class Single
    {
        int[] num = new int[]{21,11,10,8,5,6,3,4,7,2};
        public int temp ;
        public void print(int temp1)
        {
            temp = temp1;
            Console.WriteLine("Single Dimentional Array");
            foreach (int item in num)
            {
                Console.Write("\t"+item);
            }
            Console.WriteLine("\n temp:"+ temp);
        }
        
    }

    class MultiDim
    {
        int[,] num = new int[3, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 } };

        string[,] names = new string[,] { { "kittu", "phuge" }, { "Peter", "Albert" } };

        public void print()
        {
            Console.WriteLine("\nMulti-Dimentional Array");
            foreach (int item in num)
            {
                Console.Write("\t" + item);
            }
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(num[0, 0]);
            Console.WriteLine(num[0, 1]);
            Console.WriteLine(num[1, 0]);
            Console.WriteLine(num[1, 1]);
            Console.WriteLine(num[2, 0]);
            Console.WriteLine(num[2, 1]);

            Console.WriteLine("\n");
            foreach (string item in names)
            {
                Console.Write("\t" + item);
            }
            Console.WriteLine("\n--------------------------------------------------");
        }
    }

    class jaggedArray
    { public void print()
        {
            int[][] intJaggedArray = new int[3][];

            intJaggedArray[0] = new int[2] { 2,12};
            intJaggedArray[1] = new int[4] { 1,3,5,7};
            intJaggedArray[2] = new int[6] { 8,9,10,11,13,14};

            for (int i = 0; i < intJaggedArray.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);
                for (int j = 0; j < intJaggedArray[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", intJaggedArray[i][j], j == (intJaggedArray[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            Console.WriteLine("\n--------------------------------------------------");
        }
    }
}
