using System;
using System.Collections.Generic;
namespace Lists
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head {get; private set;}
        public Node<T> Tail {get; private set;}

        public int Count {get; private set;}

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        public void AddFirst(Node<T> node)
        {
            Node<T> temp = Head;

            Head = node;
            //shifting the former head
            Head.next = temp;

            Count++;

            if(Count == 1)
            {
                Tail=Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }
        private void AddLast(Node<T> node)
        {
            if(IsEmpty)
            {
                Head = node;
            }
            else{
                Tail.next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException();
            }
            Head = Head.next;
            if(Count == 1)
                Tail = null;

            Count--;
        }

        public void RemoveLast()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException();
            }
            if(Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                // find penultimate node
                var current = Head;
                while(current.next != Tail)
                {
                    current = current.next;
                }
                current.next = null;
                Tail = current;
            }
            Count--;
        }

        private bool IsEmpty => Count == 0;
    }
}