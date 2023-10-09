using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class PickingNumbersTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<int> { 4, 6, 5, 3, 3, 1 }, 3};
			yield return new object[] { new List<int> { 1, 2, 2, 3, 1, 2 }, 5};
			yield return new object[] { new List<int>
		 {
			 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3,
			 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98,
			 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4,
		 }, 22};

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void PickingNumbers_pickingNumbers_ReturnLongestSubarrayLength(List<int> arr, int expectedResult)
		{
			//Act
			var result = PickingNumbers.pickingNumbers(arr);

			//Assert
			arr.Should().OnlyContain(ele => ele <= 100 && ele >= 0);
			result.Should().Be(expectedResult);
		}
	}
}
