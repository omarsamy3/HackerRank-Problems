using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class BillDivisionTest
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<int>() { 3, 10, 2, 9 }, 1, 12, "5" };
			yield return new object[] { new List<int>() { 3, 10, 2, 9 }, 1, 7,  "Bon Appetit"};
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void BillDivision_bonAppetit_WriteBonAppetitIfSuccessORDiffNumbersOtherwise(List<int> bill, int k, int b, string expectedResult)
		{
			//Redirect console output to capture it
			using (StringWriter sw = new StringWriter())
			{
				//Arrange
				Console.SetOut(sw);

				//Act
				BillDivision.bonAppetit(bill, k, b);

				//Get the captured console output
				string consoleOutput = sw.ToString().Trim();

				//Assert
				consoleOutput.Should().NotBeNullOrWhiteSpace()
				.And.Be(expectedResult);

			}

		}
	}
}
