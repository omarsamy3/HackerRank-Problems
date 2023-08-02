using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving_HackerRank_.Easy
{
	public class MaximumElement
	{
		/// <summary>
		/// You have an empty sequence, and you will be given  queries. 
		/// Each query is one of these three types:
		/// 1 x  -Push the element x into the stack.
		/// 2    -Delete the element present at the top of the stack.
		/// 3    -Print the maximum element in the stack.
		/// </summary>
		/// <param name="operations"></param>
		/// <returns>List of Results: max numbers after manipulation.</returns>
		public static List<int> getMax(List<string> operations)
		{
			var stack = new Stack<int>();
			var maxStack = new Stack<int>();
			var result = new List<int>();

			foreach (var operation in operations)
			{
				var op = operation.Split(' ');
				int sign = int.Parse(op[0]);

				if(op.Length == 1)
				{
					if (sign == 2 && stack.Count > 0)
					{
						if (stack.Peek() == maxStack.Peek())
							maxStack.Pop();
						stack.Pop();
					}
					else if (sign == 3 && stack.Count > 0)
					{
						int max = maxStack.Peek();
						result.Add(max);
						Console.WriteLine(max);
					}
                }
				else if (op.Length == 2 && sign == 1)
				{
					var num = int.Parse(op[1]);

					stack.Push(num);

					if (maxStack.Count == 0 || num >= maxStack.Peek())
						maxStack.Push(num);
				}
            }
			return result.ToList();
		}
	}
}