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

            stack1.push(2);
            stack1.CheckList();
            stack1.push("cheese");
            stack1.CheckList();
            stack1.push(DateTime.Today);
            stack1.CheckList();
            stack1.push(null);
        }
    }
}
