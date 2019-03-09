
using DataStructures.Nodes;

namespace DataStructures.Queues
{
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
