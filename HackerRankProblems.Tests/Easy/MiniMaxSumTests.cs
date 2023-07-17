using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class MiniMaxSumTests
	{
		public static IEnumerable<object[]> TestData()
		{
			var list1 = new List<int>() { 1, 2, 3, 4, 5};
			var list2 = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };
			string result1 = "10 14";
			string result2 = "2063136757 2744467344";

			yield return new object[] { list1, result1 };
			yield return new object[] { list2, result2 };
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void MiniMaxSum_miniMaxSum_ReturnMinMaxSummation(List<int> list, string expectedResult)
		{
			//Redirect console output to capture it
			using (StringWriter sw = new StringWriter())
			{
				//Arrange
				Console.SetOut(sw);

				//Act
				MiniMaxSum.miniMaxSum(list);

				//Get the captured console output
				string consoleOutput = sw.ToString().Trim();

				//Assert
				consoleOutput.Should().NotBeNullOrWhiteSpace()
				.And.Be(expectedResult);

			}

		}
	}
}
