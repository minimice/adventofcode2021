using System;
using System.Collections.Generic;

/* Author: Lim, Chooi Guan */
/* Find me at https://linkedin.com/in/cgl88 */

namespace day1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/* Part 1 */
			var lines = System.IO.File.ReadAllLines(@"../../input.txt");
			Count(lines);

			/* Part 2 */
			lines = System.IO.File.ReadAllLines(@"../../input.txt");
			var newSums = new List<string>();
			/* Construct new sums*/
			for (var i = 0; i < lines.Length - 2; i++)
			{
				var num1 = Int32.Parse(lines[i]);
				var num2 = Int32.Parse(lines[i + 1]);
				var num3 = Int32.Parse(lines[i + 2]);
				newSums.Add((num1 + num2 + num3).ToString());
			}
			Count(newSums.ToArray());
		}

		public static void Count(string[] lines)
		{
			var previous = Int32.Parse(lines[0]);
			var count = 0;
			for (var i = 1; i < lines.Length; i++)
			{
				var current = Int32.Parse(lines[i]);
				var increased = current > previous;
				if (increased)
				{
					count++;
				}
				previous = current;
			}
			Console.WriteLine(count);
		}
	}
}
