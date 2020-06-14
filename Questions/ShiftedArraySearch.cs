using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class ShiftedArraySearch
    {
        //In a sorted array, the elements have been shifted by an unknown amount of places.
        // Find the index of the element that matches the given key.

        public static int Search(int[] numbers, int key)
        {
            int low = 0, mid, high = numbers.Length -1;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (numbers[mid] == key) return mid;
          
                if (numbers[low] < numbers[mid])
                {
                    if (key >= numbers[low] && key  < numbers[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                } else if(numbers[high] > numbers[mid])
                {
                    if (key > numbers[mid] && key <= numbers[high])
                    {
                        low = mid + 1;
                    } else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;

        }
    }
}
