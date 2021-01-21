using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree<T> where T : IComparable<T>
    {
        Node<T> root;
        bool checker = false;
        public void Insert(T value)
        {
            Node<T> node = new Node<T>(value);
            if (root == null)
            {
                root = node;
                return;
            }



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
                    if (holder.Left == null)
                    {
                        holder.Left = node;
                        return;
                    }
                    holder = holder.Left;
                }
            }


        }

        public int ChildCount(Node<T> node)
        {
            int count = 0;

            if (node.Left != null)
            {
                count++;
            }

            if (node.Right != null)
            {
                count++;
            }

            return count;
        }
        public void Delete(T value)
        {
            Node<T> node = new Node<T>(value);
            if (root == null)
            {
                root = node;
                return;
            }
            Node<T> holder = root;
            int index = node.Value.CompareTo(holder.Value);
            while (true)
            {
                if (index >= 0)
                {
                    if (holder.Right.Value.Equals(value))
                    {
                        
                        if (ChildCount(holder.Right.Right) == 0)
                        {
                            if (holder.Right.Left == null)
                            {
                                root.Right = root.Right.Left;
                            }
                            else
                            {
                                root.Right = root.Right.Right;
                            }

                            return;
                        }

                       
                        else
                        {
                            if (!(holder.Right.Right == null))
                            {
                                holder.Right.Right = holder.Right;
                                return;
                                // run the 1 node remove
                            }

                            else
                            {
                                holder = holder.Left;
                                while (holder.Right == null)
                                {
                                    holder = holder.Right;
                                }

                                root.Right = holder;
                                return;
                                // run the 2 node or more remove
                            }

                        }
                    }

                    else
                    {
                        holder = holder.Right;
                    }
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
