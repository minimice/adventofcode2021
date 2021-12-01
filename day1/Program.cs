using System;

/* Author: Lim, Chooi Guan */
/* Find me at https://linkedin.com/in/cgl88 */

namespace day1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var lines = System.IO.File.ReadAllLines(@"../../input.txt");
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
