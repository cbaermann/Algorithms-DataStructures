using System;
using System.Collections.Generic;

namespace HashTables
{
    public class LinearProbingHashSet<Key, Value>
    {
        private const int DefaultCapacity = 4;
        public int Count{get; private set;}
        public int Capacity{get;private set;}
        private Key[] keys;
        private Value[] values;

        public LinearProbingHashSet():this(DefaultCapacity)
        {

        }

        public LinearProbingHashSet(int capacity)
        {
            Capacity = capacity;
            keys = new Key[capacity];
            values = new Value[capacity];
        }

        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7ffffff) % Capacity;
        }

        public bool Contains(Key key)
        {
            if(key == null)
                throw new ArgumentNullException("Key is not allowed to be null");
            
            for(int i = Hash(key); keys[i]!=null; i=(i+1)%Capacity)
            {
                if(keys[i].Equals(key))
                    return true;
                
            }
            return false;
        }

        public Value GetValue(Key key)
        {
            if(key == null)
                throw new ArgumentNullException("Key is not allowed to be null");
            for(int i = Hash(key); keys[i]!=null; i=(i+1)%Capacity)
            {
                if(keys[i].Equals(key))
                    return values[i];
            }
            throw new ArgumentException("Key was not found");
        }

        public bool TryGet(Key key, out int index)
        {
            if(key == null)
                throw new ArgumentNullException("Key is not allowed to be null");
            for(int i = Hash(key); keys[i]!=null; i=(i+1)%Capacity)
            {
                if(keys[i].Equals(key))
                    index = i;
                    return true;
            }
            index = -1;
            return false;
        }
    }
}