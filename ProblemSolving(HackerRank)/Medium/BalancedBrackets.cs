using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Medium
{
	public class BalancedBrackets
	{
		private static char[] leftBrackets = new char[] { '(', '[', '{' };
		private static char[] rightBrackets = new char[] { ')', ']', '}' };

		/// <summary>
		/// Given n strings of brackets, determine whether each sequence of brackets is balanced.
		/// </summary>
		/// <param name="s"></param>
		/// <returns>YES, if the string is balanced. Otherwise, return NO</returns>
		public static string isBalanced(string s)
		{
			var stack = new Stack<char>();

			foreach (var c in s)
			{
				if (isLeftBracket(c))
					stack.Push(c);

				else if (isRightBracket(c))
				{
					if (stack.Count == 0)
						return "NO";

					var top = stack.Pop();
					if (!isBracketsMatch(c, top)) return "NO";
				}

			}
			return stack.Count == 0 ? "YES" : "NO";
		}


		private static bool isLeftBracket(char c)
		{
			return leftBrackets.Contains(c);
		}

		private static bool isRightBracket(char c)
		{
			return rightBrackets.Contains(c);
		}
		private static bool isBracketsMatch(char c, char top)
		{
			return indexOf(c, rightBrackets) == indexOf(top, leftBrackets);
		}

		private static int indexOf(char c, char[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == c) return i;
			}
			return -1;
		}
	}
}
