using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
	public class CatsAndAMouse
	{
		/// <summary>
		/// Two cats and a mouse are at various positions on a line 
		/// <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> respectively. 
		/// You will be given their starting positions. 
		/// Your task is to determine which cat will reach the mouse first, 
		/// assuming the mouse does not move and the cats travel at equal speed. 
		/// If the cats arrive at the same time, the mouse will be allowed to move 
		/// and it will escape while they fight.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <returns>
		/// Cat A, If cat A catches the mouse first.
		///	Cat B, If cat  catches the mouse first.
		/// Mouse C, If both cats reach the mouse at the same time, as the two cats fight and mouse escapes.
		/// </returns>
		public static string catAndMouse(int x, int y, int z)
		{
			var catA = Math.Abs(x - z);
			var catB = Math.Abs(y - z);
			if (catA < catB) return "Cat A";
			if (catB < catA) return "Cat B";
			else return "Mouse C";
		}
	}
}
