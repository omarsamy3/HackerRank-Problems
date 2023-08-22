using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class EqualStacks
	{
		/// <summary>
		/// Find the maximum possible height of the stacks such that all of the stacks are exactly the same height. 
		/// </summary>
		/// <param name="h1"></param>
		/// <param name="h2"></param>
		/// <param name="h3"></param>
		/// <returns>The Height, which the three stacks are all the same.</returns>
		public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
		{
			var stack1 = ListToStack(h1);
			var stack2 = ListToStack(h2);
			var stack3 = ListToStack(h3);

			var sum1 = stack1.Sum();
			var sum2 = stack2.Sum();
			var sum3 = stack3.Sum();

			if (sum1 == 0 || sum2 == 0 || sum3 == 0) return 0;

			while(sum1 != sum2 || sum2 != sum3)
			{
				if(sum1 >= sum2 && sum1 >= sum3)
				{
					sum1 -= stack1.Pop();
				}
				else if(sum2 >= sum1 && sum2 >= sum3)
				{
					sum2 -= stack2.Pop();
				}
				else
				{
					sum3 -= stack3.Pop();
				}

            }

			return sum1;
		}

		/// <summary>
		/// Convert this <paramref name="list"/> of any type, to a stack.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <returns>The Stack of items from this <paramref name="list"/></returns>
		private static Stack<T> ListToStack<T>(List<T> list)
		{
			var stack = new Stack<T>();
			list.Reverse();
			foreach (var item in list)
			{
				stack.Push(item);
			}

			return stack;
		}
	}
}
