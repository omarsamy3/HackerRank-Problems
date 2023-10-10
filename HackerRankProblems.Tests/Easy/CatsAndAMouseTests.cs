using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class CatsAndAMouseTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { 2, 5, 4, "Cat B" };
			yield return new object[] { 1, 2, 3, "Cat B" };
			yield return new object[] { 1, 3, 2, "Mouse C" };

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void CatsAndAMouse_CatsAndMouse_ReturnTheWinner(int x, int y, int z, string expectedResult)
		{
			//Act
			var result = CatsAndAMouse.catAndMouse(x, y, z);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
