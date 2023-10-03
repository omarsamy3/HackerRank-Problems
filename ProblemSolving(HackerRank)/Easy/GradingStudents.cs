using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Tests.Easy
{
	public class GradingStudents
	{
		/// <summary>
		/// Takes a list of integer numbers as Student <paramref name="grades"/>, to calculate the final grades
		/// after rounding it if there's a room for this.
		/// </summary>
		/// <param name="grades"></param>
		/// <returns>The list of success grades after rounding it.</returns>
		public static List<int> gradingStudents(List<int> grades)
		{
			var RoundedResult = new List<int>();
			foreach (var grade in grades)
			{
				if (grade < 38) RoundedResult.Add(grade);
				else RoundedResult.Add(AfterRounded(grade));

			}

			return RoundedResult;
		}

		/// <summary>
		/// If the difference between the <paramref name="grade"/> and the next multiple of 5 is less than 3, 
		/// round <paramref name="grade"/> up to the next multiple of 5.
		/// </summary>
		/// <param name="grade"></param>
		/// <returns>The <paramref name="grade"/> after rounding.</returns>
		private static int AfterRounded(int grade)
		{
			var diff = 5 - (grade % 5);
			return (diff < 3) ? grade + diff : grade;
		}
	}
}
