using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using ProblemSolving_HackerRank_.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class EqualStacksTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] {
				new List<int>() { 3, 2, 1, 1, 1 },
				new List<int>() { 4, 3, 2 },
				new List<int>() { 1, 1, 4, 1 }, 5 };
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void EqualStacks_equalStacks_ReturnTheEqualityHeight(List<int> h1, List<int> h2,
		List<int> h3, int expectedResult)
		{
			//Act
			var result = EqualStacks.equalStacks(h1, h2, h3);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
