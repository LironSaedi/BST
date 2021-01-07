using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable<T>
    {

        //private int x;

        //public int GetX()
        //{
        //    return x;
        //}

        //public void SetX(int newx)
        //{
        //    x = newx;
        //}

        //public int Y { get; set; }

        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }

        public T Value { get; set; }

        public Node(T Value)
        {
            this.Value = Value;
        }


    }
}

