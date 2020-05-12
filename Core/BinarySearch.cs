using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class BinarySearch
    {
        public static bool Search(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid = (low + high) / 2;

            while (low <= high)
            {
                if (target < array[mid]) high = mid - 1;
                else if (target > array[mid]) low = mid + 1;
                else return true;
                mid = (low + high) / 2;
            }
            return false;
        }
    }
}
