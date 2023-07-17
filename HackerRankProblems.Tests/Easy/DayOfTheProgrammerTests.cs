using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class DayOfTheProgrammerTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { 1984, "12.09.1984" };
			yield return new object[] { 1800, "12.09.1800" };
			yield return new object[] { 2016, "12.09.2016" };
			yield return new object[] { 2017, "13.09.2017" };
			yield return new object[] { 1918, "26.09.1918" };

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void DayOfTheProgrammer_dayOfTheProgrammer_ReturnFullDayAsString(int input, string expectedResult)
		{
			//Act
			var result = DayOfTheProgrammer.dayOfProgrammer(input);

			//Assert
			result.Should().Be(expectedResult);
		}
	}
}
