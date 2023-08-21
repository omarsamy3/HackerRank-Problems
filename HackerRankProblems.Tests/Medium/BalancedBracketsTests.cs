using FluentAssertions;
using ProblemSolving_HackerRank_.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Medium
{
	public class BalancedBracketsTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { "{[()]}", "YES" };
			yield return new object[] { "{[(])}", "NO" };
			yield return new object[] { "{{[[(())]]}}", "YES" };
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void BalancedBrackets_isBalanced_ReturnYESOrNO(string s, string expectedResult)
		{
			//Act
			var result = BalancedBrackets.isBalanced(s);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
