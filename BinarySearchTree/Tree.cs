﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree<T> where T : IComparable<T>
    {
        Node<T> root;

        public void Insert(T value)
        {
            Node<T> node = new Node<T>(value);
            if (root == null)
            {


                root = node;
                return;

            }


            root = node;
            Node<T> holder = root;
            while (true)
            {
                int index = node.Value.CompareTo(holder.Value);
                if (index >= 0)
                {
                    if (holder.Right == null)
                    {
                        holder.Right = node;
                        return;
                    }
                    holder = holder.Right;
                    
                }


                else
                {
                    if(holder.Left==null)
                    {
                        holder.Left = node;
                        return;
                    }
                    holder = holder.Left;
                }
            }
        }

        #region oldcode
        //    if (root == null)
        //    {
        //        Node<T> newNode = new Node<T>(value);
        //        root = newNode;
        //        return;
        //    }

        //    Node<T> node = new Node<T>(value);
        //    Node<T> holder = root;

        //while (true)
        //{

        //    int index = node.Value.CompareTo(holder.Value);
        //    if (index == 0 || index == 1)
        //    {
        //        if (holder.Right == null)
        //        {
        //            node = holder.Right;
        //            //insert to the right and exit the function
        //        }
        //        holder = holder.Right;
        //    }

        //    else
        //    {
        //        holder.Left = node; //go to the left side of the tree
        //    }

        //}

        #endregion
    }

}
