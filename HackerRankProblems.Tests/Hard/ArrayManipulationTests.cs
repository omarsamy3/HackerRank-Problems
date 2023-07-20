using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using ProblemSolving_HackerRank_.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Hard
{
	public class ArrayManipulationTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { 10, new List<List<int>>()
											{
											new List<int>() { 1, 5, 3 } ,
											new List<int>() { 4, 8, 7 } ,
											new List<int>() { 6, 9, 1 } ,
											}, 10 };

			yield return new object[] { 5, new List<List<int>>()
											{
											new List<int>() { 1, 2, 100 } ,
											new List<int>() { 2, 5, 100 } ,
											new List<int>() { 3, 4, 100 } ,
											}, 200 };

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ArrayManipulation_arrayManipulation_ReturnTheMaxResultSum (int n, List<List<int>> queries, int expectedResult)
		{
			//Act
			var result = ArrayManipulation.arrayManipulation(n, queries);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
