using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	internal static class CompareTheTriplets
	{
		public static List<int> compareTriplets(List<int> a, List<int> b)
		{
			if (a.Count != b.Count) 
				throw new ArgumentException("Two lists must be the same size.");

			var result1 = 0;
			var result2 = 0;
			for (int i = 0; i < a.Count; i++)
			{
				if (a[i] < 1 || a[i] > 100 &&
					b[i] < 1 || b[i] > 100) 
					throw new ArgumentOutOfRangeException("Must be in 1 - 100 range.");

				if (a[i] > b[i]) result1++;
				if (a[i] < b[i]) result2++;
			}

			return new List<int>() { result1, result2 };
		}

		
	}
}
