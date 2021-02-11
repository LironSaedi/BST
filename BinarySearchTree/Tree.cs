using System;
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



            Node<T> holder = root;
            while (true)
            {
                int index = node.Value.CompareTo(holder.Value);
                if (index >= 0)
                {
                    if (holder.Right == null)
                    {
                        holder.Right = node;
                        node.Parent = holder;
                        return;
                    }
                    holder = holder.Right;

                }


                else
                {
                    if (holder.Left == null)
                    {
                        holder.Left = node;
                        node.Parent = holder;
                        return;
                    }
                    holder = holder.Left;
                }
            }


        }


        private Node<T> Minimum(Node<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
        public void Delete(T value)
        {

            Node<T> node;
            node = Search(value);

            if (node.ChildCount() == 2)
            {
                Node<T> holder = Minimum(node.Right);
                node.Value = holder.Value;
                node = holder;
            }

            if (node.ChildCount() == 0)
            {
                if (node == root)
                {
                    root = null;
                }

                else if (node.IsLeftChild())
                {
                    node.Parent.Left = null;
                }
                else if (node.IsRightChild())
                {
                    node.Parent.Right = null;
                }
            }

            else
            {
                Node<T> temp = node.Left;
                if (node.Left == null)
                {
                    temp = node.Right;
                }


                if (node == root)
                {
                    root = temp;
                }
                else if (node.IsLeftChild())
                {
                    node.Parent.Left = temp;
                }
                else if (node.IsRightChild())
                {
                    node.Parent.Right = temp;
                }
                temp.Parent = node.Parent;

            }


        }


        public Node<T> Search(T value)
        {
            Node<T> holder = root;
            while (holder != null)
            {
                int val = value.CompareTo(holder.Value);

                if (val < 0)
                {
                    holder = holder.Left;
                }
                else if (val > 0)
                {
                    holder = holder.Right;
                }
                else if (val == 0)
                {
                    return holder;
                }
            }

            return null;
        }

        public List<T> Preorder()
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            var curr = root;
            List<T> item = new List<T>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                curr = stack.Pop();
                item.Add(curr.Value);

                if (curr.Right != null)
                {
                    stack.Push(curr.Right);
                }
                if (curr.Left != null)
                {
                    stack.Push(curr.Left);
                }


            }
            return item;

        }

        public List<T> LevelOrder()
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            var curr = root;
            List<T> item = new List<T>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                queue.Dequeue();

                if(curr.Left != null)
                {
                    queue.Enqueue(curr.Left);
                }

                if(curr.Right != null)
                {
                    queue.Enqueue(curr.Right);
                }

            }

            return item;

        }

        /*
        public void DeleteOld(T value)
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
                        var rightchild = holder.Right.Right;
                        if (rightchild.ChildCount() == 0)
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
        */
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
        //stack.Push(root);
        //    else
        //    {
        //        holder.Left = node; //go to the left side of the tree
        //    }

        //}

        #endregion


        /*
        Stack<Node<T>> stack = new Stack<Node<T>>();
        var current = root;

        stack.Push(root);


            List<T> items = new List<T>();

            while(stack.Count > 0)
            {
                current = stack.Pop();
                items.Add(current.Value);

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }

            }

            return items;

    
        */
    }
}
