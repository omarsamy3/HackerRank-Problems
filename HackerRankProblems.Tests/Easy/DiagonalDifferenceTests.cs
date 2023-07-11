using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class DiagonalDifferenceTests
	{
		public static IEnumerable<object[]> TestData()
		{
			var SquareMatrix1 = new List<List<int>>()
			{
				new List<int>(){1, 2, 3},
				new List<int>(){4, 5, 6},
				new List<int>(){9, 8, 9},
			};
			var SquareMatrix2 = new List<List<int>>()
			{
				new List<int>(){11, 2, 4},
				new List<int>(){4, 5, 6},
				new List<int>(){10, 8, -12},
			};
			yield return new object[] {SquareMatrix1, 2};
			yield return new object[] { SquareMatrix2, 15 };
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void DiagonalDifference_diagonalDifference_returnTheDifferenceAsInteger(List<List<int>> arr, int expectedResult)
		{
			//Act
			var result = DiagonalDifference.diagonalDifference(arr);

			//Assert
			arr.ForEach(row => row.Should().OnlyContain(ele => ele >= -100 && ele <= 100));
			result.Should().Be(expectedResult);
		}
	}
}
