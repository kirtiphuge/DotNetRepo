using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Generics
{
    class SwapGenerics<T>
    {
        public void Swap(T a,T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap : \n First No : {0} \t Second No : {1}", a, b);
        }
    }
}
