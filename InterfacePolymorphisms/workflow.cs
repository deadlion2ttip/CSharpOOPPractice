using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphisms
{
    class workflow
    {
        private List<IAction> _program;

        public workflow(List<IAction> program)
        {
            if (program.Count > 0 && program != null)
            {
                _program = program;
            }
            else
            {
                throw new ArgumentException("Program must contain at least one action.", "program");
            }
        }

        public void Run()
        {
            foreach (IAction action in _program)
            {
                action.Execute();
            }
        }

    }
}
