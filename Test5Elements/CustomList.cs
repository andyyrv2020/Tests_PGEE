using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5Elements
{
    class CustomList
    {
        private class Node
        {
            private object element;
            private Node next;
            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;
            }
            public Node(object element)
            {
                this.Element = element;
            }
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        private Node head;
        private Node tail;
        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }
        public void Add(object element)
        {
            Node newNode = new Node(element);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                this.tail.Next = newNode;
                this.tail = newNode;
            }
            this.Count++;
        }
    }
}