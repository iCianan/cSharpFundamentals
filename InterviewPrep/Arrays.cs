using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Arrays
    {
        public int[] TwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        if (array[i] > array[j])
                        {
                            return new int[] { array[j], array[i] };
                        }
                        else
                        {
                            return new int[] { array[i], array[j] };

                        }
                    } 
                }
            }
            return new int[] { };
        }
        public int[] TwoNumberSumTernary(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int firstNumber = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNumber = array[j];        
                    if (firstNumber + secondNumber == targetSum)
                    {
                        return firstNumber > secondNumber ? new int[] { secondNumber, firstNumber } : new int[] { firstNumber, secondNumber };                        
                    } 
                }
            }
            return new int[] { };
        }
        public int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+ 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                       
                    } 
                }                
            }
            return array;
        }

        public void Playground()
        {
            int[] myArray = new int[6];

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            string[] days = { "Monday", "Tuesday", "Wednesday" };

            for (int i = numbers.Length - 1; i < 0; i--)
            {
                Console.WriteLine(numbers); ;
            }

        }
    }
}
