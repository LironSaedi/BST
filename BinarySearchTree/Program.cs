using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tree<int> tree = new Tree<int>();

            tree.Insert(5);
            tree.Insert(0);
            tree.Insert(10);
            tree.Insert(7);
            //tree.Insert(11);
            tree.Delete(10);
           
           
            // TO DO FORNEXT TIME 1/20/21 : FIx the DElete with 1 child. Seems to be deleteing the whole right side. Also test out the delete with 2 children and finsih the left hand side.
            ;



        }
    }
}
