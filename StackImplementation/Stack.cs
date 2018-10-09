using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Stack
    {
        private List<Object> _store = new List<Object>();

        public void push(object input)
        {
            if (input == null)
            {
                throw new InvalidOperationException("input must not be null");
            }
            _store.Add(input);
        }

        public void CheckList()
        {
            foreach (object item in _store)
            {
                Console.WriteLine(item);
            }
        }
    }
}
