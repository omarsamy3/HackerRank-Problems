using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class Staircase
	{
		/// <summary>
		/// The Staircase problem involves printing a pattern of '#' symbols representing a staircase of a given height 'n'. 
		/// Each line contains a specific number of '#' symbols, forming a staircase shape.
		/// </summary>
		/// <param name="n"></param>
		public static void staircase(int n)
		{
			for (int i = 1; i <= n; i++)
			{
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
		}
	}
}
