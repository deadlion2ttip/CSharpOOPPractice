using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    class InputHandler
    {
        static public void handleInput(Stopwatch stopwatch)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "start":
                    stopwatch.Start();
                    break;
                case "stop":
                    stopwatch.Stop();
                    break;
                case "read":
                    Console.WriteLine(stopwatch.TimeElapsed);
                    break;
                default:
                    Console.WriteLine("Please enter a valid command");
                    break;

            }
        }
    }
}
