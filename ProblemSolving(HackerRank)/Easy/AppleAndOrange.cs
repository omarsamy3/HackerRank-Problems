using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_HackerRank_.Easy
{
    public static class AppleAndOrange
    {
        /// <summary>
        /// Sam's house has an apple tree and an orange tree that yield an abundance of fruit. 
        /// Using the information given below, determine the number of apples and oranges that land on Sam's house.
        /// Complete the 'countApplesAndOranges' function below.
        /// </summary>
        /// <param name="s">House start point</param>
        /// <param name="t">House end point</param>
        /// <param name="a">Apple tree position point</param>
        /// <param name="b">Orange tree position point</param>
        /// <param name="apples">Thrown apples points</param>
        /// <param name="oranges">Thrown oranges points</param>

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            Console.WriteLine(GetCatchedFruit(apples, a, s, t));
            Console.WriteLine(GetCatchedFruit(oranges, b, s, t));
        }

        private static int GetCatchedFruit(List<int> fruit, int treePos, int startPoint, int endPoint)
        {
            int Catchedfruit = 0;

            for (int i = 0; i < fruit.Count; i++)
            {
                int AppleAbsPos = fruit[i] + treePos;
                if (AppleAbsPos >= startPoint && AppleAbsPos <= endPoint) Catchedfruit++;
            }

            return Catchedfruit;
        }
    }
}
