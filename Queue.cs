using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queues
    {
        private int[] QueueContainer = new int[25];
        private int inPos = 0;
       

        public void Enqueue(int a)
        {
            if (inPos > 25)
            {
                Console.WriteLine("Queue Full");
            }
            else
            {
                QueueContainer[inPos] = a;
                inPos++;
            }

        }
        public void Dequeue()
        {
            if (inPos == 0)
            {
                Console.WriteLine("Queue Empty");
            }
            else
            {
                Console.WriteLine($"Item Dequeued is {QueueContainer[0]}");
                for(int i = 0;i < inPos; i++)
                {
                    this.QueueContainer[i] = this.QueueContainer[i + 1];
                }
                inPos--;
                
            }

        }
        public void DisplayQ()
        {
            for (int i = 0; i < inPos; i++)
            {
                Console.WriteLine(QueueContainer[i]);
            }
        }



    }
}
