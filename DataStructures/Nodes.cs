using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Nodes
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
}
