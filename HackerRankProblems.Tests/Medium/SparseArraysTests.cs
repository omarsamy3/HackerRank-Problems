using FluentAssertions;
using ProblemSolving_HackerRank_.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Medium
{
	public class SparseArraysTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { 
				new List<string>() { "aba", "baba", "aba", "xzxb"},
				new List<string>() { "aba", "xzxb", "ab"}, 
				new List<int>(){ 2, 1, 0 } };
			yield return new object[] { 
				new List<string>() { "def", "de", "fgh" },
				new List<string>() { "de", "lmn", "fgh" }, 
				new List<int>(){ 1, 0, 1 } };
			yield return new object[] { 
				new List<string>() { "abcde","sdaklfj","asdjf","na","basdn",
					"sdaklfj","asdjf","na","asdjf","na","basdn","sdaklfj","asdjf" },
				new List<string>() { "abcde", "sdaklfj", "asdjf", "na", "basdn" }, 
				new List<int>(){ 1, 3, 4, 3, 2 } };


		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SparesArray_matchingStrings_ReturnListOfIntegerResults(List<string> stringList, List<string> queries, List<int> expectedResult)
		{
			//Act
			var result = SparseArrays.matchingStrings(stringList, queries);

			//Assert
			result.Should().Equal(expectedResult);
		}
	}
}
