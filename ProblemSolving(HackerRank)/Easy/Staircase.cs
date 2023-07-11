using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class Staircase
	{
		public static void staircase(int n)
		{
			for (int i = 1; i <= n; i++)
			{
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
		}
	}
}
