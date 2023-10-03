using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class GradingStudentsTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<int>() { 73, 67, 38, 33 },
										new List<int>() { 75, 67, 40, 33 }};

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void GradingStudents_gradingStudents_ReturnRoundedGrades(List<int> arr, List<int> expectedResult)
		{
			//Act
			var result = GradingStudents.gradingStudents(arr);

			//Assert
			arr.Should().OnlyContain(ele => ele <= 100 && ele >= 0);
			result.Should().Equal(expectedResult);
		}
	}
}
