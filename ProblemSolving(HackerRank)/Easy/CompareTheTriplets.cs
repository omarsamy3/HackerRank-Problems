using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class CompareTheTriplets
	{
		/// <summary>
		/// Given two arrays of integers representing Alice's and Bob's ratings for various aspects,
		/// compare their ratings and determine the winner.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>A list of two elements: the first list result, and the second list result.</returns>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public static List<int> compareTriplets(List<int> a, List<int> b)
		{
			if (a.Count != b.Count) 
				throw new ArgumentException("Two lists must be the same size.");

			var result1 = 0;
			var result2 = 0;
			for (int i = 0; i < a.Count; i++)
			{
				if (a[i] > b[i]) result1++;
				if (a[i] < b[i]) result2++;
			}

			return new List<int>() { result1, result2 };
		}

		
	}
}
