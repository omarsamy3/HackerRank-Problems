using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	internal static class PlusMinus
	{
		/// <summary>
		/// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
		/// Print the decimal value of each fraction on a new line with 6 places after the decimal.
		/// </summary>
		/// <param name="arr"></param>
		public static void plusMinus(List<int> arr)
		{
			var n = arr.Count;
			decimal possitive = 0.0m;
			decimal negative = 0.0m;
			decimal zeros = 0.0m;

			for (int i = 0; i < n; i++)
			{
				var num = arr[i];
				if (num > 0) possitive++;
				else if (num < 0) negative++;
				else zeros++;
			}

			Console.WriteLine($"{(possitive / n).ToString("F6")}\n" +
				$"{(negative / n).ToString("F6")}\n" +
				$"{(zeros / n).ToString("F6")}");
        }
	}
}
