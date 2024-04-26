using System;

namespace LinkedListTests
{
    internal class LinkedList
    {
        internal ListNode Head { get; set; }

        internal void Add(int val)
        {
            ListNode newNode = new ListNode(val);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                ListNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        internal int SumOfPositiveValues()
        {
            int sum = 0;
            ListNode current = Head;
            while (current != null)
            {
                if (current.Value > 0)
                {
                    sum += current.Value;
                }
                current = current.Next;
            }
            return sum;
        }
    }
}
