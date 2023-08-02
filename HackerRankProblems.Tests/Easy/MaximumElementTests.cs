using FluentAssertions;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class MaximumElementTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<string>()
			   {
			   "1 97","2","1 20","2","1 26","1 20","2","3","1 91","3"
			   }, new List<int>(){ 26, 91 } };

		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void MaximumElement_GetMax_ReturnMaxElementList(List<string> operations, List<int> expectedResult)
		{
			//Act
			var result = MaximumElement.getMax(operations);

			//Assert
			result.Should().Equal(expectedResult);
		}
	}
}
