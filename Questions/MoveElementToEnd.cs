using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class MoveElementToEnd
    {

        public static List<int> MoveToEndButBetter(List<int> array, int toMove)
        {
            int start = 0;
            int end = array.Count - 1;
            while (start < end)
            {
                if (array[start] == toMove && array[end] != toMove)
                {
                    swap(start, end, array);
                    start++;
                    end--;
                }
                else if (array[start] == toMove && array[end] == toMove) end--;
                else start++;               
            }
            return array;

        }

        // O(n) T | O(1) S
        public static List<int> MoveToEnd(List<int> array, int toMove)
        {
            int i = array.Count - 1;
            while (i >= 0)
            {
                if (array[i] != toMove) ScanAndSwap(i, toMove, array);
                i--;
            }
            return array;
        }
        private static void ScanAndSwap(int i, int toMove, List<int> array)
        {
            for (int j = i-1; j >= 0; j--)
            {
                if (array[j] == toMove)
                {
                    swap(j, i, array);
                }
            }
        }

        private static void swap(int i, int j, List<int> numbers)
        {
            int temp = numbers[j];
            numbers[j] = numbers[i];
            numbers[i] = temp;
        }
    }
}
