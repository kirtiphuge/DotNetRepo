using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day17_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {

            //Parallel.For(0, 1000000, x => Func1());

            /*Console.WriteLine("1....");
            Thread obj = new Thread(MultiThreading.Fuc1);
            obj.Start();

            Console.WriteLine("---------------------------------------------------");
            MultiThreading m = new MultiThreading();
             Thread obj2 = new Thread(m.Func2);
            obj2.Start();

            Console.WriteLine("---------------------------------------------------");


            // Create ThreadA object
            Thread back = new Thread(new  ThreadStart(ChildThreadA));
            // Create ThreadB object
            Thread fore = new Thread(new ThreadStart(ChildThreadB));
            // Set ThreadB as background thread
            back.IsBackground = true;
            back.Start();
            fore.Start();

            Thread.CurrentThread.Name = "Main";
            for (int i = 0; i < 20; i++)
            {
                if (i == 5)
                    fore.Abort();  //Abort Foreground thread
                Console.WriteLine(Thread.CurrentThread.Name);
            }

            try
            {
                Divide d = new Divide();
                d.divide();
                Thread t = new Thread(d.divide);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Synchronize s = new Synchronize();
            Thread t = new Thread(() => s.WithDraw(20));
            Thread t1 = new Thread(() => s.WithDraw(50));
            t1.Start();
            t.Start();


            using (var m1 = new Mutex(false, "Day17_Multithreading"))
            {
                if (!m1.WaitOne(5000, false))

                {
                    Console.WriteLine("Already Instance running");
                    Console.ReadLine();
                    return;

                }
                Console.WriteLine("App Running");*/
            MultiThreading m = new MultiThreading();
           
            ThreadPool.QueueUserWorkItem(m.Func2);

            WaitCallback callBack;

            callBack = new WaitCallback(PooledFunc);
            ThreadPool.QueueUserWorkItem(callBack,
               "Is there any screw left?");
            ThreadPool.QueueUserWorkItem(callBack,
               "How much is a 40W bulb?");
            ThreadPool.QueueUserWorkItem(callBack,
               "Decrease stock of monkey wrench");


            Console.ReadLine();
            
        }

        static void PooledFunc(object state)
        {
            Console.WriteLine("Processing request '{0}'", (string)state);
            // Simulation of processing time
            Thread.Sleep(2000);
            Console.WriteLine("Request processed");
        }



        public static void ChildThreadA()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Background");
            }
        }
        public static void ChildThreadB()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Foreground");
            }
        }

        static void Func()
        {
            string x = "kittu";
            for(int i=0;i<10000;i++)
            {
                Console.WriteLine(x);
                Console.WriteLine(i);
            }
        }

        static void Func1()
        {
            string x = "kittu";
            for (int i = 0; i < 10000; i++)
            {
                x = x + "s";
                
            }
        }

       
    }
}
