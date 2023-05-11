namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);
            myQueue.Enqueue(8);
            myQueue.Enqueue(9);
            myQueue.Enqueue(10);

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i <= 10; i++)
            {
                if (myQueue.Count != 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Current queue : {myQueue.Dequeue()}");      
                    Console.ReadKey();
                }
            }
        }
    }
}