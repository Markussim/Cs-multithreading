using System;
using System.Threading;
using System.Collections.Generic;


namespace Cs_multithreading
{
    class Program
    {
        public static int variablething = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("hmm");

            List<Thread> myListThingGräj = new List<Thread>();

            for (int i = 0; i < 10000; i++)
            {
                myListThingGräj.Add(new Thread(CallToChildThread));
            }

            foreach (var item in myListThingGräj)
            {
                item.Start();
            }

            var test = 1;
            foreach (var item in myListThingGräj)
            {
                item.Join();
                //Console.WriteLine(variablething);
                test += variablething;
            }


        }

        public static void CallToChildThread(object hello_there)
        {

            var new_var = variablething;
            Thread.Sleep(new Random().Next(0, variablething * 100));
            variablething = new_var + 1;
            Console.WriteLine(variablething);
        }
    }
}
