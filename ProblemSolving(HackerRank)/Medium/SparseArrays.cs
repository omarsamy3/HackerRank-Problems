using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Medium
{
	public static class SparseArrays
	{
		/// <summary>
		/// There is a collection of input strings and a collection of query strings. 
		/// For each query string, determine how many times it occurs in the list of input strings.
		/// Return an array of the results.
		/// </summary>
		/// <param name="stringList"></param>
		/// <param name="queries"></param>
		/// <returns>An array of the results</returns>
		public static List<int> matchingStrings(List<string> stringList, List<string> queries)
		{
			var result = new int[queries.Count];

			for (int i = 0; i < queries.Count; i++)
			{
				var query = queries[i];
				foreach (var item in stringList)
				{
					if (item == query) result[i]++;
				}
			}

			return result.ToList();
		}
	}
}
