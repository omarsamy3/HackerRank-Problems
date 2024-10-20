using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
    public class AppleAndOrangeTests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 7, 10, 4, 12, new List<int>() { 2, 3, -4 }, new List<int>() { 3, -2, -4 }, "1" };
            yield return new object[] { 7, 10, 4, 12, new List<int>() { 2, 3, -4 }, new List<int>() { 3, -2, -4 }, "2" };

        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void AppleAndOrange_countApplesAndOranges_WriteApplesCoundAndOrangeCountThatFallOnHouse(int s, int t, int a, int b, List<int> apples, List<int> oranges, string expectedResult)
        {
            //Redirect console output to capture it
            using (StringWriter sw = new StringWriter())
            {
                //Arrange
                Console.SetOut(sw);

                //Act
                AppleAndOrange.countApplesAndOranges(s, t, a, b, apples, oranges);

                //Get the captured console output
                string consoleOutput = sw.ToString().Trim();

                //Assert
                consoleOutput.Contains(expectedResult);

            }
        }
    }
}
