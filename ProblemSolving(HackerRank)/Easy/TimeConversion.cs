using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class TimeConversion
	{
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
