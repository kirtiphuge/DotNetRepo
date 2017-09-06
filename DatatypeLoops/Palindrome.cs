using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DatatypeLoops
{
    class Palindrome
    {
        public void CheckPalindrome(String name)
        {
            int length = name.Length;
            char[] arr = name.ToCharArray();
            char[] arr1 = name.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            int counter=0;
            for(int i=0;i<length;i++)
            {
                if(arr[i]==arr1[i])
                {
                    counter++; 
                }
            }

            if(counter==length)
            {
                Console.WriteLine("Palindrome");

            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
