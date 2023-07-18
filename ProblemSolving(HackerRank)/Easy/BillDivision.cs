using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class BillDivision
	{
		/// <summary>
		/// <para>It should print Bon Appetit if the bill is fairly split. 
		/// Otherwise, it should print the integer amount of money that Brian owes Anna.</para>
		/// <para><paramref name="bill"/> is the array of integers representing the cost of each item ordered.</para>
		/// <para><paramref name="k"/> is an integer representing the zero-based index of the item Anna doesn't eat.</para>
		/// <para><paramref name="b"/> is the amount of money that Anna contributed to the bill.</para>
		/// </summary>
		/// <param name="bill"></param>
		/// <param name="k"></param>
		/// <param name="b"></param>
		public static void bonAppetit(List<int> bill, int k, int b)
		{
			var annaActualPrice = bill.Sum() / 2 - bill[k]/2;

			if(annaActualPrice == b) Console.WriteLine("Bon Appetit");
			else Console.WriteLine(Math.Abs(annaActualPrice - b));
        }
	}
}
