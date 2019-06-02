using System;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 2)
			{
				Console.WriteLine($"Hello {args[0]} {args[1]}!");
			} 
			else
			{
				Console.WriteLine("Welcome!");
			}				
		}
	}
}
