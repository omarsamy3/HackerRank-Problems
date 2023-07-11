using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class SimpleArraySumTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<int>() { 1, 2, 3, 4, 10, 11 }, 31};

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SimpleArraySum_simpleArraySum_returnASumResultAsInteger(List<int> arr, int expectedResult)
		{
			//Act
			var result = SimpleArraySum.simpleArraySum(arr);

			//Assert
			arr.Should().OnlyContain(ele => ele <= 1000 && ele >= 0);
			result.Should().Be(expectedResult);
		}
	}
}
