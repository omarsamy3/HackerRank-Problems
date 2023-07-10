using ProblemSolving_HackerRank_;
using ProblemSolving_HackerRank_.Easy;

//Simple Array Sum
Console.WriteLine(SimpleArraySum.simpleArraySum(new List<int>() { 1, 2, 3, 4, 10, 11 })); //31

//Compare the Triplets
Helper.PrintList(CompareTheTriplets.compareTriplets(new List<int>() { 17, 28, 30 },
													 new List<int>() { 99, 16, 8 }
													 )); //[2, 1]

//A Very Big Sum
Console.WriteLine(
	AVeryBigSum.aVeryBigSum(new List<long>()
	{ 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }
							)); //5000000015



var SquareMatrix = new List<List<int>>()
{
	new List<int>(){1, 2, 3},
	new List<int>(){4, 5, 6},
	new List<int>(){9, 8, 9},
};

Helper.PrintSquareMatrix(SquareMatrix);
Console.WriteLine(DiagonalDifference.diagonalDifference(SquareMatrix)); //2


PlusMinus.plusMinus(new List<int>() { -4, 3, -9, 0, 4, 1 });
