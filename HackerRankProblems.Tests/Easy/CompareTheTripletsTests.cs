using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class CompareTheTripletsTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<int>() { 17, 28, 30 },
										new List<int>() { 99, 16, 8 },
										new List<int>() { 2, 1 }
			};

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void CompareTheTriplets_compareTheTriplets_returnAListResult(List<int> a, List<int> b, List<int> expectedResult)
		{
			//Act
			var result = CompareTheTriplets.compareTriplets(a, b);

			//Assert
			a.Should().OnlyContain(ele => ele <= 100 && ele >= 0);
			b.Should().OnlyContain(ele => ele <= 100 && ele >= 0);
				;
			result.Should().BeEquivalentTo(expectedResult)
				.And.HaveCount(2);
		}
	}
}
