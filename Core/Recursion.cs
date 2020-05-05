using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Recursion
    {
        public string TakeShower()
        {
            return "Showering";
        }
        public string CookFood()
        {
            Random random = new Random();
            string[] items = { "Oatmeal", "Eggs", "Protein Shake" };
            return items[random.Next(0, items.Length)];
        }
        public string EatBreakfast()
        {
            var meal = CookFood();
            return $"Eating {meal}";
        }
        public void WakeUp()
        {
            TakeShower();
            EatBreakfast();
            Console.WriteLine("Ok ready to go to work");
        }
        public int IterativeArraySum(int[] numbers, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public int IterativeArraySumDelgate(int[] numbers, int size)
        {
            if (size == 0)
            {
                return 0;
            }
            int lastNumber = numbers[size - 1];
            int allButLastSum = IterativeArraySum(numbers, size - 1);
            return lastNumber + allButLastSum;
        }
        public int IterativeArraySumRecursive(int[] numbers, int size)
        {
            if (size == 0)
            {
                return 0;
            }
            int lastNumber = numbers[size - 1];
            int allButLastSum = IterativeArraySumRecursive(numbers, size - 1);
            return lastNumber + allButLastSum;
        }

    }
}
