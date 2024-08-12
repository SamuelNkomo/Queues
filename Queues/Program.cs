using System.Collections;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Sam");
            myQ.Enqueue("That dog");
            myQ.Enqueue("Him");

            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:{0}",myQ.Count);
            Console.WriteLine("\tValues:");
            PrintValues(myQ);
            Console.WriteLine( myQ.Dequeue().ToString());
            PrintValues(myQ);
            Console.WriteLine(myQ.Dequeue().ToString());
            PrintValues(myQ);
        }

        private static void PrintValues(Queue myQ)
        {
            foreach(var item in myQ)
            {
                Console.WriteLine("\t{0}",item);
            }
        }
    }
}
