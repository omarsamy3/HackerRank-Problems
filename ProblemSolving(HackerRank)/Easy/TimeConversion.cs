using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class TimeConversion
	{
		/// <summary>
		/// Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
		/// </summary>
		/// <param name="s"></param>
		/// <returns>The converted time in 24-hour time.</returns>
		public static string timeConversion(string s)
		{
			var hours = int.Parse($"{s[0]}{s[1]}");
			var type = $"{s.Substring(s.Length - 2, 2)}";
			var MinSec = s.Substring(2, 6);
            var Result = new StringBuilder();

			if (type == "PM" && hours < 12)
				Result.Append($"{hours + 12}");

			else if (type == "AM" && hours == 12)
				Result.Append($"00");
			else
				Result.Append(hours.ToString("00"));
			
			Result.Append(MinSec);
            return Result.ToString();
		}
	}
}
