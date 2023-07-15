using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class MiniMaxSum
	{
		/// <summary>
		/// Given five positive integers, 
		/// find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
		/// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
		/// </summary>
		/// <param name="arr"></param>
		public static void miniMaxSum(List<int> arr)
		{
			arr.Sort();
			var result = new long[2];
			for (int i = 0; i < arr.Count - 1; i++)
			{
				result[0] += arr[i];
				result[1] += arr[i + 1];
			}

			Console.WriteLine($"{result[0]} {result[1]}");
        }
	}
}
