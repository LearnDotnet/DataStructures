using System;
using DataStructures.Queues;
using DataStructures.BinarySearchTree;
namespace DataStructures
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            #region BST
            //BinarySearchTree BST = new BinarySearchTree();
            //BSTNode root = null;
            //root = BST.Insert(root, 10);
            //root = BST.Insert(root, 5);
            //root = BST.Insert(root, 20);

            //root = BST.Insert(root, 7);
            //root = BST.Insert(root, 15);
            //root = BST.Insert(root, 2);
            //root = BST.Insert(root, 25);
            //Console.WriteLine("Pre Order");
            //BST.PrintDFS_PreOrder(root);
            //Console.WriteLine();

            //Console.WriteLine("In Order");
            //BST.PrintDFS_InOrder(root);
            //Console.WriteLine();

            //Console.WriteLine("Post Order");
            //BST.PrintDFS_PostOrder(root);
            //Console.WriteLine();


            //Console.WriteLine("Max={0},Min={1}", BST.FindMax(root), BST.FindMin(root));
            //Console.WriteLine("IsExists({0})={1}", 15, BST.IsExists(root,15));
            //Console.WriteLine("IsExists({0})={1}", 10, BST.IsExists(root, 10));
            //Console.WriteLine("IsExists({0})={1}", 5, BST.IsExists(root, 5));
            //Console.WriteLine("IsExists({0})={1}", 12, BST.IsExists(root, 12));

            //Console.WriteLine("IsExists({0})={1}", 8, BST.IsExists(root, 8));
            //Console.WriteLine("IsExists({0})={1}", 6, BST.IsExists(root, 6));

            //BST.PrintBFS(root);

            #endregion


            Queue Q = new Queue();
            Q.Enqueue(10);
            Q.Enqueue(15);
            Q.Enqueue(20);

            Console.WriteLine("Dequeue={0}", Q.DeQueue());
            Console.WriteLine("Dequeue={0}", Q.DeQueue());
            Console.WriteLine("Dequeue={0}", Q.DeQueue());
            Console.WriteLine("Dequeue={0}", Q.DeQueue());




            Console.ReadLine();
        }
    }
}
