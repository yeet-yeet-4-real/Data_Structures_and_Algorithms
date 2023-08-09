using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_console
{
    class LinkedList
    {
        public Node first;
        public Node last;
        private int length;

        public LinkedList()
        {
            this.length = 0;
            this.first = this.last = null;
        }

        private bool IsEmpty() => this.first == null;

        public void AddFirst(int value)
        {
            Node node = new Node(value);

            if (IsEmpty())
            {
                this.length++;
                this.first = node;
                this.last = this.first;
                return;
            }

            this.length++;
            node.next = this.first;
            this.first = node;
            
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);
            if (IsEmpty())
            {
                this.length++;
                this.first = node;
                this.last = this.first;
                return;
            }

            this.length++;
            this.last.next = node;
            this.last = this.last.next;
        }

        public void DeleteFirst()
        {
            if (IsEmpty()) return;
            if (this.first == this.last)
            {
                this.length--;
                this.first = this.last = null;
                return;
            }

            Node node = this.first.next;
            this.length--;
            this.first.next = null;
            this.first = node;
            
        }

        private Node GetPreviousNode(Node node)
        {
            Node currentNode = this.first;
            while (currentNode != null)
            {
                if (currentNode.next == node)
                    return currentNode;
                currentNode = currentNode.next;
            }
            return null;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                throw new Exception("Linked List is empty");

            if (this.first == this.last)
            {
                this.length--;
                this.first = this.last = null;
                return;
            }
            
            Node node = GetPreviousNode(this.last);
            this.length--;
            this.last = node;
            this.last.next = null;
        }

        public int IndexOf(int value)
        {
            int index = 0;
            if (IsEmpty()) return -1;

            Node node = this.first;
            while (node != null)
            {
                if (node.value == value) return index;
                node = node.next;
                index++;
            }
            return -1;
        }

        public int Size()
        {
            return this.length;
        }

        public bool Contains(int value)
        {
            if (IsEmpty())
                return false;
            return IndexOf(value) != -1;
        }
    }
}
