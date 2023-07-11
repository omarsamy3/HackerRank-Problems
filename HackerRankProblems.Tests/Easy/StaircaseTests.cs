using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class StaircaseTests
	{
		public static IEnumerable<object[]> TestData()
		{
			string pattern = "#\r\n    ##\r\n   ###\r\n  ####\r\n #####\r\n######";

			yield return new object[] { 6, pattern };
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void Staircase_staircase_ReturnStaircaseString(int n, string expectedResult)
		{
			//Redirect console output to capture it
			using (StringWriter sw = new StringWriter())
			{
				//Arrange
				Console.SetOut(sw);

				//Act
				Staircase.staircase(n);

				//Get the captured console output
				string consoleOutput = sw.ToString().Trim();

				// Count the number of '#' symbols in the output
				int hashCount = consoleOutput.Count(c => c == '#');
				int actualHashCount = (n * (n + 1)) / 2;

				//Assert
				consoleOutput.Should().NotBeNullOrWhiteSpace()
				.And.Be(expectedResult);

				hashCount.Should().Be(actualHashCount);

				n.Should().BeInRange(0, 100);
			}

		}
	}
}
