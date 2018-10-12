using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphisms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAction> program = new List<IAction>();

            program.Add(new Attack());
            program.Add(new Defend());
            program.Add(new Attack());
            program.Add(new DefendBadly());
            program.Add(new Die());

            workflow story = new workflow(program);

            story.Run();
        }
    }
}
