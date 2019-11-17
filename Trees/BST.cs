using System;
using System.Collections.Generic;

namespace Trees
{
    public class TreeNode<T> where T: IComparable<T>
    {
        public T Value{get; set;}
        public TreeNode<T> Left{get;  set;}
        public TreeNode<T> Right{get; set;}

        public TreeNode(T value)
        {
            Value = value;
        }

        public void Insert(T newValue)
        {
            int compare = newValue.CompareTo(Value);
            if(compare==0)
                return;
            if(compare<0)
            {
                if(Left==null)
                {
                    Left = new TreeNode<T>(newValue);
                }
                else
                {
                    Left.Insert(newValue);
                }
            }
            else
                {
                    if(Right==null)
                    {
                        Right = new TreeNode<T>(newValue);
                    }
                    else
                    {
                        Right.Insert(newValue);
                    }
                }
        }
        public TreeNode<T> Get(T value)
        {
            int compare = value.CompareTo(Value);
            if(compare == 0)
            {
                return this;
            }
            if(compare <0)
            {
                if(Left!=null)
                    return Left.Get(value);
            }
            else
            {
                if(Right!=null)
                    return Right.Get(value);
            }
            return null;
        }

        public IEnumerable<T> TraverseInOrder()
        {
            var list = new List<T>();
            InnerTraverse(list);
            return list;
        }

        private void InnerTraverse(List<T> list)
        {
            if(Left!=null)
                Left.InnerTraverse(list);

            list.Add(Value);

            if(Right!=null)
                Right.InnerTraverse(list);
        }

        public T Min()
        {
            if(Left!=null)
                return Left.Min();
            return Value;
        }
        public T Max()
        {
            if(Right!=null)
                return Right.Max();
            return Value;
        }
    }
    public class Bst<T> where T: IComparable<T>
    {
        private TreeNode<T> root;
        public void Remove(T value)
        {
            root = Remove(root, value);
        }
        public void Remove(TreeNode<T> subtreeRoot, T value)
        {
            if(subtreeRoot==null)
                return null;
            int compareTo = value.CompareTo(subtreeRoot.Value);
            if(compareTo<0)
            {
                subtreeRoot.Left = Remove(subtreeRoot.Left, value);
            }
            else if( compareTo > 0)
            {
                subtreeRoot.Left = Remove(subtreeRoot.Right, value);
            }
            else
            {
                if(subtreeRoot.Left == null)
                {
                    return subtreeRoot.Right;
                }
                if(subtreeRoot.Right==null)
                {
                    return subtreeRoot.Left;
                }

                subtreeRoot.Value = subtreeRoot.Right.Min();
                subtreeRoot.Right = Remove(subtreeRoot.Right, subtreeRoot.Value);
            }
            return subtreeRoot;
        }
    
    

        public TreeNode<T> Get(T value)
        {
            return root?.Get(value);
        }
        public T Min()
        {
            if(root==null)
                throw new InvalidOperationException("Empty Tree");
            return root.Min();
        }
        public T Max()
        {
            if(root==null)
                throw new InvalidOperationException("Empty Tree");
            return root.Max();
        }

        public void Insert(T value)
        {
            if(root==null)
                root= new TreeNode<T>(value);
            else
            {
                root.Insert(value);
            }
        }

        public IEnumerable<T> TraverseInOrder()
        {
            if(root!=null)
            {
                return root.TraverseInOrder();
            }
            return null;
        }
    }
}