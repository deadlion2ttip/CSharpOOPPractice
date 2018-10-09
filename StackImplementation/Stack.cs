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

        
        public object Pop()
        {
            if (_store.Count > 0)
            {
                int endOfList = _store.Count - 1;
                Object returned = _store[endOfList];
                _store.RemoveAt(endOfList);
                return returned;
            } else
            {
                throw new InvalidOperationException("Cannot Pop an empty list");
            }
        }

        public void Clear()
        {
            _store.Clear();
            Console.WriteLine("Stack Cleared");
        }

        public void Push(object input)
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
