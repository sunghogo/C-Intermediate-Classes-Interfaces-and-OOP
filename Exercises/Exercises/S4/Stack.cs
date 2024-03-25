using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S4
{
    public class Stack
    {
        private ArrayList Array { get; set; }

        public Stack()
        {
            Array = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj is null)
            {
                throw new InvalidOperationException("Cannot push null objects.");
            }

            Array.Add(obj);
        }

        public object Pop()
        {
            if (Array.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            object obj = Array[Array.Count - 1];
            Array.RemoveAt(Array.Count - 1);

            return obj;
        }

        public void Clear()
        {
            Array.Clear();
            Console.WriteLine("Stack cleared");
        }

        public void Display()
        {
            Console.WriteLine("Stack currently contains: ");
            for (int i = 0; i < Array.Count; i++)
            {
                Console.WriteLine($"{i}. {Array[i]}");
            }
        }
    }
}
