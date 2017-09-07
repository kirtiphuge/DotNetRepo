using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Multithreading
{
    public class Synchronize
    {
        private Object thisLock = new Object();
        int balance = 100;
        public void WithDraw(int amount)
        {
            
            lock (thisLock)
            {

                if (balance >= amount)
                {
                    Console.WriteLine("Balance before Withdrawal :  " + balance);
                    Console.WriteLine("Amount to Withdraw        : -" + amount);
                    balance = balance - amount;
                    Console.WriteLine("Balance after Withdrawal  :  " + balance);
                    
                }
                else
                {
                    Console.WriteLine("Transaction failed"); // transaction rejected
                }
            }
        }

    }
}
