using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class BSTNode
    {
        public int data;
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    public class BinarySearchTree
    {
        //public BSTNode root;

        public BSTNode GetBSTNode(int data)
        {
            BSTNode bstNode = new BSTNode(data);
            return bstNode;
        }

        public BSTNode Insert(BSTNode root, int data)
        {
            if (root == null)
            {
                root = GetBSTNode(data);
                return root;
            }
            else if (data > root.data)
            {
                root.right = Insert(root.right, data);

            }
            else
            {
                root.left = Insert(root.left, data);
            }
            return root;
        }

        public void PrintDFS_PreOrder(BSTNode root)
        {
            if (root == null)
                return;
            Console.Write(root.data + ",");
            PrintDFS_PreOrder(root.left);
            PrintDFS_PreOrder(root.right);


        }
        public void PrintDFS_InOrder(BSTNode root)
        {
            if (root == null)
                return;
            PrintDFS_InOrder(root.left);
            Console.Write(root.data + ",");
            PrintDFS_InOrder(root.right);


        }
        public void PrintDFS_PostOrder(BSTNode root)
        {
            if (root == null)
                return;
            PrintDFS_PostOrder(root.left);
            PrintDFS_PostOrder(root.right);
            Console.Write(root.data + ",");


        }

        public int FindMax(BSTNode root)
        {
            if (root.right == null)
                return root.data;
            return FindMax(root.right);

        }

        public int FindMin(BSTNode root)
        {
            if (root.left == null)
                return root.data;
            return FindMin(root.left);

        }

        public bool IsExists(BSTNode root, int data)
        {
            if (root == null)
                return false;
            else if (root.data == data)
                return true;
            else if (data > root.data)
            {
                return IsExists(root.right, data);
            }
            else
            {
                return IsExists(root.left, data);
            }

            // return false;
        }

        public void PrintBFS(BSTNode root)
        {
            Queue<BSTNode> bfsQueue = new Queue<BSTNode>();
            bfsQueue.Enqueue(root);
            BSTNode current = null;
            while (bfsQueue.Any())
            {
                current = bfsQueue.Peek();
                Console.Write(current.data + ",");
                if (current.left != null)
                    bfsQueue.Enqueue(current.left);
                if (current.right != null)
                    bfsQueue.Enqueue(current.right);
                bfsQueue.Dequeue();

            }
        }


    }

    public class Queue
    {
        LinkedListNode front;
        LinkedListNode rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public LinkedListNode GetNode(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            return node;
        }

        public void Enqueue(int data)
        {

            LinkedListNode newNode = GetNode(data);
            if (front == null)
            {
                front = rear = newNode;
                return;
            }

            rear.next = newNode;
            rear = newNode;


        }

        public int GetPeek()
        {
            if (front != null)
            {
                return front.data;
            }
            return -1;
        }

        public int DeQueue()
        {
            int peek = -1;
            if (front != null)
            {
                peek = front.data;
                front = front.next;
            }

            return peek;


        }

    }





}
