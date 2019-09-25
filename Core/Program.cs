using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays arrays = new Arrays();
            //arrays.ListDaysInOrder();
            //arrays.ReplaceAllDaysWithMonths();
            Queue queue = new Queue();
            int[] numbers =
            {
                1,5,7,11,15,17,24,26,28,32,36,39,40,45,52,53,58,59,63,64,69,72,77,78,98,99
            };
            foreach (var num in numbers)
            {
                queue.Enqueue(num);
            }
            foreach (var num in numbers)
            {
                queue.Dequeue();
            }

        }
    }
}