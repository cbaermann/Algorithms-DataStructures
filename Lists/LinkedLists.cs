using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{

    public class Node<T>
    {
        public T value{get;set;}
        public Node<T> next{get;set;}

        public Node(T val)
        {
            value = val;
        }
    }
}