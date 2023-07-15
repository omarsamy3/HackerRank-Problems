using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class TimeConversionTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { "12:01:00PM", "12:01:00" };
			yield return new object[] { "12:01:00AM", "00:01:00" };

		}		

		[Theory]
		[MemberData(nameof(TestData))]
		public void SimpleArraySum_simpleArraySum_returnASumResultAsInteger(string input, string expectedResult)
		{
			//Act
			var result = TimeConversion.timeConversion(input);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
