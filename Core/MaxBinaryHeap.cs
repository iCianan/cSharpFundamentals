using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MaxBinaryHeap
    {
        public List<int> values;
        public MaxBinaryHeap()
        {
            values = new List<int>();
        }

        public void Insert(int value)
        {
            values.Add(value);
            BubbleUp(values);
        }

        private void BubbleUp(List<int> values)
        {
            int index = values.Count - 1;
            int element = values[index];
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                int parent = values[parentIndex];
                if (element <= parent) break;
                values[parentIndex] = element;
                values[index] = parent;
                index = parentIndex;                
            }
        }
    }
}
