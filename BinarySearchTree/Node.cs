using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable<T>
    {

        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }

        public T Value { get; set; }

        public Node(T Value)
        {
            this.Value = Value;
        }


    }


}

