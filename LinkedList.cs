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

        private class Node
        {
            public int value;
            public Node next;

            public Node(int val)
            {
                this.value = val;
            }
        }

        public LinkedList() =>
            this.first = this.last = null;

        public void AddFirst(int value)
        {
            Node node = new Node(value);

            if (this.first == null)
            {
                this.first = node;
                this.last = this.first;
                return;
            }

            node.next = this.first;
            this.first = node;
        }

        // This works (for now at least)
        public void AddLast(int value)
        {
            Node node = new Node(value);
            if (this.first == null)
            {
                this.first = node;
                this.last = this.first;
                return;
            }

            this.last.next = node;
            this.last = this.last.next;
        }

        // Idk what to do here yet
        public void DeleteFirst()
        {
            if (this.first == null) return;

            Node node = this.first.next;
            this.first = null;
        }

        // Time complexity: O(n)
        public void DeleteLast()
        {
            Node node = this.first;
            Node next = node.next;

            if (node == null) return;
            if (node == this.first && node.next == null)
                this.first = null;

            do // I hate goddamn do while loops
            {
                // Find a way to keep track of each node in the list
                if (next.next == null)
                    node.next = this.last = null;

                node = next; // this.first = this.first.next
                next = node.next;

            } while (next.next != null);
        }

        public int IndexOf(int value)
        {
            int index = 0;
            if (this.first == null) return -1;

            Node node = this.first;
            while (node.value != value)
            {
                node = node.next;
                index++;
            }
            return index;
        }

        public bool Contains(int value)
        {
            if (this.first == null) return false;
            Node node = this.first;

            while (node.next != null)
            {
                if (node.value == value) return true;
                node = node.next;
            }
            return false;
        }
    }
}
