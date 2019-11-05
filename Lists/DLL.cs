using System;
using System.Collections.Generic;
namespace Lists
{
    public class DoublyLinkedNode<T>
    {
        public DoublyLinkedNode<T> Next{get;internal set;}
        public DoublyLinkedNode<T> Previous{get;internal set;}

        public T Value {get;set;}

        public DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }

    public class DoublyLinkedList<T>
    {
        public DoublyLinkedNode<T> Head{get; private set;}
        public DoublyLinkedNode<T> Tail{get; private set;}

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }
        private void AddFirst(DoublyLinkedNode<T> node)
        {
            //save head
            DoublyLinkedNode<T> temp = Head;
            //point head to node
            Head = node;

            //insert rest of list after head
            Head.Next = temp;

            if(IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                //before: 1(head)<--->5<-->7-->null
                //after: 3(head)<-->1<->5<->7->null;

                //update "previous" ref of former head
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        public void AddLast(DoublyLinkedNode<T> node)
        {
            if(IsEmpty)
                Head = node;
            
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if(IsEmpty)
                throw new InvalidOperationException();
            //shift head
            Head = Head.Next;

            Count--;
            if(IsEmpty)
                Tail = null;
            else
                Head.Previous = null;
        }

        public void RemoveLast()
        {
            if(IsEmpty)
                throw new InvalidOperationException();
            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null; //null the last node
                Tail = Tail.Previous; //shift the tail
            }
            Count--;
        }

        public int Count{get;set;}
        public bool IsEmpty => Count == 0;
        
    }
}