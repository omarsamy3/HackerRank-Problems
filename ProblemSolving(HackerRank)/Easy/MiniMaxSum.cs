using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class MiniMaxSum
	{
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
