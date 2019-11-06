using System;
using System.Collections.Generic;

namespace Lists
{
    public class LinkedStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>
        public T Peek()
        {
            if(IsEmpty)
                throw new InvalidOperationException();
            return list.Head.value;
        }

        public void Pop()
        {
            if(IsEmpty)
                throw new InvalidOperationException();
            list.RemoveFirst();
        }

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public bool IsEmpty => Count==0;
        public int Count;
    }
}