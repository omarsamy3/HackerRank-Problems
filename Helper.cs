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
	}
}
