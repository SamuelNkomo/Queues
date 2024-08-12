namespace GenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();

            numbers.Enqueue("One");
            numbers.Enqueue("Two");
            numbers.Enqueue("Three");
            numbers.Enqueue("Four");
            numbers.Enqueue("Five");
            foreach (String number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Dequieing {0}", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            Console.WriteLine("Dequuieing {0}", numbers.Dequeue());

            String[] test = { "one", "two", "three" };
            Queue<string> newQueue = new Queue<string>();
            Console.WriteLine("New cue from an array");
            foreach (string number in newQueue)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("was four found: {0}", newQueue.Contains("four"));
            Console.WriteLine("Clear the queue");
            newQueue.Clear();
            Console.WriteLine("new Que : {0}",newQueue.Count);
        }
    }
}
