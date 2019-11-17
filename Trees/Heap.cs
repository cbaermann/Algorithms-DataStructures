using System;
using System.Collections.Generic;
namespace Trees
{
    //Heaps must be from a complete BST. 
    //Max heap, max must be at root node. 
    //Min heap, min must be at root node. 
    //can store heaps as arrays. 
    public class MaxHeap<T> where T: IComparable<T>
    {
        private const int DefaultCapacity = 4;
        private T[] heap;
        
        public int Count{get; private set;}
        
        public bool isFull => Count == heap.Length;
        public bool isEmpty => Count == 0;

        public void Insert(T value)
        {
            if(isFull)
            {
                var newHeap = new T[heap.Length * 2];
                Array.Copy(heap, 0, newHeap, 0, heap.Length);
            }
            heap[Count] = value;

            Swim(Count);

            Count++;
        }

        private void Swim(int indexOfSwimmingItem)
        {
            T newValue = heap[indexOfSwimmingItem];
            while(indexOfSwimmingItem > 0 && IsParentLess(indexOfSwimmingItem))
            {
                heap[indexOfSwimmingItem] = GetParent(indexOfSwimmingItem);
                indexOfSwimmingItem = ParentIndex(indexOfSwimmingItem);
            } 

            heap[indexOfSwimmingItem] = newValue;
            bool IsParentLess(int swimmingItemIndex)
            {
                return newValue.CompareTo(GetParent(swimmingItemIndex)) > 0;
            }
        }

        public IEnumerable<T> Values()
        {
            foreach(var item in heap)
            {
                yield return item;
            }
        }

        private T GetParent(int index)
        {
            return heap[ParentIndex(index)];
        }

        private int ParentIndex(int index)
        {
            return (index -1) / 2;
        }

        public MaxHeap():this(DefaultCapacity)
        {

        }
        private MaxHeap(int capacity)
        {
            heap = new T[capacity];
        }
    }
}