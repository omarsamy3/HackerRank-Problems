using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;

namespace HackerRankProblems.Tests.Easy
{
    public class PlusMinusTests
    {
		[Fact]
		public void PlusMinus_plusMinus_ReturnString1()
		{
			//Arrange - variables, classes, mocks
			var testArray = new List<int>() { 1, -2, 0, 3, -4 };
			string expectedResult = "0.400000\n0.400000\n0.200000";

			//Redirect console output to capture it
			using (StringWriter sw = new StringWriter())
			{
				Console.SetOut(sw);

				//Act
				PlusMinus.plusMinus(testArray);

				//Get the captured console output
				string consoleOutput = sw.ToString().Trim();

				//Assert
				consoleOutput.Should().NotBeNullOrWhiteSpace();
				consoleOutput.Should().Be(expectedResult);
			}

		}

		[Fact]
		public void PlusMinus_plusMinus_ReturnString2()
		{
			//Arrange - variables, classes, mocks
			var testArray = new List<int>() { -4, 3, -9, 0, 4, 1 };
			string expectedResult = "0.500000\n0.333333\n0.166667";
			
			//Redirect console output to capture it
			using (StringWriter sw = new StringWriter())
			{
				Console.SetOut(sw);

				//Act
				PlusMinus.plusMinus(testArray);

				//Get the captured console output
				string consoleOutput = sw.ToString().Trim();

				//Assert
				consoleOutput.Should().Be(expectedResult);
			}
		}
	}
}