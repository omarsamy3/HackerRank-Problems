using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class DiagonalDifference
	{
		/// <summary>
		/// Given a square matrix, calculate the absolute difference between the sums of its diagonals.
		/// </summary>
		/// <param name="arr"></param>
		/// <returns>The absolute difference of diagonals sums.</returns>
		public static int diagonalDifference(List<List<int>> arr)
		{
			var n = arr.Count();
			var LTR = 0;
			var RTL = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i == j) LTR += arr[i][j];
					if(i + j == n - 1) RTL += arr[i][j];
				}
            }
            return Math.Abs(LTR - RTL);
		}
	}
}
