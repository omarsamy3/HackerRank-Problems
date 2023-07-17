using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class DayOfTheProgrammer
	{
		/// <summary>
		/// Given a year, <paramref name="year"/>, 
		/// find the date of the 256th day of that year according to the official Russian calendar during that year. 
		/// Then print it in the format dd.mm.yyyy, 
		/// where dd is the two-digit day, mm is the two-digit month, and yyyy is <paramref name="year"/>.
		/// </summary>
		/// <param name="year"></param>
		/// <returns>The day of the programmer as a string.</returns>
		public static string dayOfProgrammer(int year)
		{
			if (year == 1918) return "26.09.1918"; //Transition year
			return isLeap(year) ? $"12.09.{year}" : $"13.09.{year}";
		}

		private static bool isLeap(int year)
		{
			bool leap;
			if (year < 1918) //Julian
			{
				leap = (year % 4 == 0) ? true : false;

			}
			else //Gregorian
			{
				leap = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
				? true
				: false;
			}

			return leap;
		}
	}
}
