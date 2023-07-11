using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using ProblemSolving_HackerRank_.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class AVeryBigSumTests
	{
		public static IEnumerable<object[]> TestData()
		{
			yield return new object[] { new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, 5000000015 };
			yield return new object[] { new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000006 }, 5000000016 };
			
		}


		[Theory]
		[MemberData(nameof(TestData))]
		public void AVeryBigSum_aVeryBigSum_ReturnLongNumber(List<long> ar, long expected)
		{
			//Act
			var result = AVeryBigSum.aVeryBigSum(ar);

			//Assert
			result.Should().Be(expected);

		}
		
	}
}
