using System;

/* Author: Lim, Chooi Guan */
/* Find me at https://linkedin.com/in/cgl88 */

namespace day2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			PartOne();
			PartTwo();
		}

		public static void PartTwo()
		{
			/* Part 2 */
			var lines = System.IO.File.ReadAllLines(@"../../input.txt");

			var hPos = 0;
			var vPos = 0;

			var aim = 0;

			foreach (var line in lines)
			{
				var movement = line.Split(' ')[0];
				var step = Int32.Parse(line.Split(' ')[1]);
				switch (movement)
				{
					case "forward":
						hPos += step;
						vPos += aim * step;
						break;
					case "up":
						aim -= step;
						break;
					case "down":
						aim += step;
						break;
					default:
						break;
				}
			}
			Console.WriteLine(hPos * vPos);
		}

		public static void PartOne()
		{
			/* Part 1 */
			var lines = System.IO.File.ReadAllLines(@"../../input.txt");

			var hPos = 0;
			var vPos = 0;
			foreach (var line in lines)
			{
				var movement = line.Split(' ')[0];
				var step = Int32.Parse(line.Split(' ')[1]);
				switch (movement)
				{
					case "forward":
						hPos += step;
						break;
					case "up":
						vPos -= step;
						break;
					case "down":
						vPos += step;
						break;
					default:
						break;
				}
			}
			Console.WriteLine(hPos * vPos);
		}
	}
}
