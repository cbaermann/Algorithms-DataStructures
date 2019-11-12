using System;
using System.Collections.Generic;

namespace SymbolTables
{
    public class SequentialSearchSt<Tkey, TValue>
    {
        private class Node 
        {
            public Tkey Key {get; }
            public TValue Value {get;set;}

            public Node Next{get;set;}

            public Node(Tkey key, TValue value, Node next)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }
        private Node _first;
        private readonly EqualityComparer<Tkey> _comparer;

        public int Count {get;set;}

        public SequentialSearchSt()
        {
            _comparer = EqualityComparer<Tkey>.Default;
        }
        public SequentialSearchSt(EqualityComparer<Tkey> comparer)
        {
            _comparer = comparer ?? throw new ArgumentNullException();
        }

        public bool TryGet(Tkey key, out TValue val)
        {
            for(Node x = _first; x!=null; x=x.Next)
            {
                if(_comparer.Equals(key, x.Key))
                {
                    val = x.Value;
                    return true;
                }
            }
            val = default(TValue);
            return false;
        }

        public void Add(Tkey key, TValue val)
        {
            if(key==null)
            {
                throw new ArgumentNullException("Key can not be null");
            }
            for(Node x = _first; x!=null; x=x.Next)
            {
                if(_comparer.Equals(key, x.Key))
                {
                    x.Value = val;
                    return;
                }
            }
            _first = new Node(key, val, _first);
            Count++;
        }

        public bool Contains(Tkey key)
        {
            for(Node x = _first; x!=null; x =x.Next)
            {
                if(_comparer.Equals(key, x.Key))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Tkey> Keys()
        {
            for(Node x = _first; x!=null; x=x.Next)
            {
                yield return x.Key;
            }
        }
    }
}