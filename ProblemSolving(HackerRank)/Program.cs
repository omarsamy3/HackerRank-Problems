using ProblemSolving_HackerRank_;
using ProblemSolving_HackerRank_.Easy;




//TryAll();
void TryAll()
{
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



	//Diagonal Difference
	var SquareMatrix = new List<List<int>>()
{
	new List<int>(){1, 2, 3},
	new List<int>(){4, 5, 6},
	new List<int>(){9, 8, 9},
};

	Helper.PrintSquareMatrix(SquareMatrix);
	Console.WriteLine(DiagonalDifference.diagonalDifference(SquareMatrix)); //2

	//Plus Minus
	PlusMinus.plusMinus(new List<int>() { -4, 3, -9, 0, 4, 1 });

	//Staircase
	Staircase.staircase(10);

	//Min Max Sum
	MiniMaxSum.miniMaxSum(
	   new List<int>()
	   { 256741038, 623958417, 467905213, 714532089, 938071625 }); //2063136757 2744467344

	//Time Conversion
	Console.WriteLine(TimeConversion.timeConversion("12:01:00PM"));
	Console.WriteLine(TimeConversion.timeConversion("05:01:00PM"));
	Console.WriteLine(TimeConversion.timeConversion("12:01:00AM"));
	Console.WriteLine(TimeConversion.timeConversion("01:01:00AM"));

}