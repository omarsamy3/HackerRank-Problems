using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_
{
	internal static class Helper
	{
		public static void PrintList<T>(List<T> list)
		{
            Console.Write("[ ");
            foreach (T item in list)
			{
				Console.Write(item + " ");
			}
            Console.WriteLine("]");
        }

		public static void PrintSquareMatrix<T>(List<List<T>> arr)
		{
			var n = arr.Count;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(arr[i][j] + "   ");
                }
                Console.WriteLine();
            }
		}
	}
}
