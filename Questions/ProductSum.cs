using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
	public static class ProductSum
	{
		public static int ProductSum1(List<object> array, int multi = 1)
		{
			int sum = 0;
			foreach (var item in array)
			{
				if (item is int)
				{
					sum += (int)item;
				}
				else
				{
					sum += ProductSum1((List<object>)item, multi + 1);
				}

			}
			return sum * multi;
		}
	}
}
