using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedListQueues
{
    class Queues
    {
        public QNode front, rear;

        public Queues()
        {
            this.front = this.rear = null;
        }

        public void enqueue(int key)
        {
            QNode temp = new QNode(key);
            if(this.rear == null)
            {
                this.rear = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
        }

        public void dequeue()
        {
            if(this.rear == null)
            {
                return;
            }
            this.front = this.front.next;
            if(this.front == null)
            {
                this.rear = null;
            }
        }
    }
}
