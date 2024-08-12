namespace LInkedListQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queues q = new Queues();
            q.enqueue(10);
            q.enqueue(20);
            q.enqueue(30);
            q.enqueue(40);

           // q.enqueue();
           // q.enqueue();

            Console.WriteLine("Queue fornt:" + ((q.front != null) ? (q.front).key : -1));
            Console.WriteLine("Queue rear:" + ((q.rear != null) ? (q.rear).key : -1));

        }
    }
}
