using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Stack
{
    class Stack<T>
    {
        // Nested class StackNode representing elements in the stack.
        class StackNode<T>
        {
            public T Value { get; set; }                    // Value stored in node
            public StackNode<T> Next { get; set; }          // next node

            public StackNode(T value)
            {
                Value = value; // node is node value
                Next = null; // next node starts empty
            }
        }

        private StackNode<T> top; // top value or first value 
        private int count; // count 

        public int Count
        {
            get { return count; } // count
        }

        public Stack()
        {
            top = null; // the top value starts null
            count = 0; // count starts at 0
        }

        public void Push(T value)
        {
            StackNode<T> newNode = new StackNode<T>(value);  // create a new node
            newNode.Next = top; // the node next is the top node
            top = newNode; // top nod becomes new value
            count++; // new count 
        }

        public T Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty."); // check if top value empty

            T value = top.Value; // t value is top value
            top = top.Next; // top is now moved to the next node
            count--; // lose one in count
            return value; // return the value of the T node
        }

        public T Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty."); // check if top value empty

            return top.Value; // return top value 
        }

        public void Clear()
        {
            top = null; // clear 
            count = 0;
        }
    }

}
