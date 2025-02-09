using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5Elements
{
    class CustomStack<T>
    {
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> PrevNode { get; private set; }

            public Node(T value, Node<T> prev = null)
            {
                this.Value = value;
                this.PrevNode = prev;
            }
        }

        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            var newNode = new Node<T>(element, firstNode);
            firstNode = newNode;
            Count++;
        }
    }
}
