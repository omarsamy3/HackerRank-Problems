using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public class PickingNumbers
	{
		/// <summary>
		/// Given an array of integers <paramref name="a"/>, find the longest subarray 
		/// where the absolute difference between any two elements is less than or equal to 1.
		/// </summary>
		/// <param name="a"></param>
		/// <returns>The Length of the longest subarray achieves the condition.</returns>
		public static int pickingNumbers(List<int> a)
		{
			a.Sort();
			var n = a.Count;
			var results = new int[n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (a[j] == a[i] || a[j] == a[i] + 1) results[i]++;
				}
			}
            return results.Max();
		}
		public static int pickingNumbersUsingLinq(List<int> a)
		{
			int maxCount = 0;

			foreach (int num in a)
			{
				int count = a.Count(x => x == num) + a.Count(x => x == num + 1);
				maxCount = Math.Max(maxCount, count);
			}

			return maxCount;
		}
		public static int pickingNumbers1(List<int> a)
		{
			int maxCount = 0;

			for (int i = 0; i < a.Count; i++)
			{
				int count = 0;

				for (int j = 0; j < a.Count; j++)
				{
					if (a[j] == a[i] || a[j] == a[i] + 1) count++;					
				}

				maxCount = Math.Max(maxCount, count);
			}

			return maxCount;
		}
	}
}
