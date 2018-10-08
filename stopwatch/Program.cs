using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();


            timer.Start();
            Thread.Sleep(2000);
            timer.Stop();
            Console.WriteLine(timer.TimeElapsed);

            
        }

       
    }
}
