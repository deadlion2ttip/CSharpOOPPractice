using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack1 = new Stack();

            stack1.Push(2);

            stack1.Push("cheese");

            stack1.Push(DateTime.Today);

            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
        }
    }
}
