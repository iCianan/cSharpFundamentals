using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = 3.21;
			var y = 5.45;

			var numbers = new[] {3.32, 13.9, 393.7621};
			List<double> grades = new List<double>() {32.324, 43.432, 9.2313, 0.9310, 20.1};
			

			double sum = 0;
			double gradeTotal = 0;

			foreach (var item in numbers)
			{
				sum += item;

			}
			foreach (var item in grades)
			{
				gradeTotal += item;
			}

			gradeTotal /= grades.Count;

			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}

			var result = x + y;
			if (args.Length == 2)
			{
				Console.WriteLine($"Hello {args[0]} {args[1]}!");
			} 
			else
			{
				Console.WriteLine($"Welcome! {result} and {sum} and {gradeTotal:N1}!");
			}				
		}
	}
}
