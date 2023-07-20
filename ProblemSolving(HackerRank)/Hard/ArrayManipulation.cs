using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Hard
{
	public static class ArrayManipulation
	{
		/// <summary>
		/// Starting with a 1-indexed array of zeros with size <paramref name="n"/> 
		/// and a list of operations <paramref name="queries"/>, 
		/// for each operation: 
		/// add a value to each the array element between two given indices, inclusive.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="queries"></param>
		/// <returns>The maximum value in the array.</returns>
		public static long arrayManipulation(int n, List<List<int>> queries)
		{
			var result = new long[n + 1]; // Use n+1 elements to handle 1-indexing
			foreach (var q in queries)
			{
				var a = q[0];
				var b = q[1];
				var k = q[2];

				// Update the prefix sum array with the difference array technique
				result[a - 1] += k;
				result[b] -= k;
			}

			// Calculate the cumulative sum to find the maximum value
			long maxVal = 0;
			long sum = 0;
			for (int i = 0; i < n; i++)
			{
				sum += result[i];
				maxVal = Math.Max(maxVal, sum);
			}

			return maxVal;
		}
	}
}
