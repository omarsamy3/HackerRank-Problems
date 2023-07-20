using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public static class PrintTheElementsOfALinkedList
	{
		public static void printLinkedList(SinglyLinkedListNode head)
		{
			var current = head;
			while(current != null)
			{
				Console.WriteLine(current.data);
				current = current.next;
			}            
        }
	}
}
