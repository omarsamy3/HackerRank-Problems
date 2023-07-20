using ProblemSolving_HackerRank_;
using ProblemSolving_HackerRank_.Easy;
using ProblemSolving_HackerRank_.Hard;
using ProblemSolving_HackerRank_.Medium;




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

	//Day of the programmer
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(1984)); //12.09.1984
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(2017)); //13.09.2017
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(1800)); //12.09.1984
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(2016)); //12.09.2017
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(1918)); //26.09.2017

	//Bill Division
	BillDivision.bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 12);
	BillDivision.bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 7);

	//Sparse Arrays
	Helper.PrintList(SparseArrays.matchingStrings(
	new List<string>() { "aba", "baba", "aba", "xzxb" },
	new List<string>() { "aba", "xzxb", "ab" })); //[2, 1, 0]

	Helper.PrintList(SparseArrays.matchingStrings(
		new List<string>() { "def", "de", "fgh" },
		new List<string>() { "de", "lmn", "fgh" })); //[1, 0, 1]
	Helper.PrintList(SparseArrays.matchingStrings(
		new List<string>() { "abcde","sdaklfj","asdjf","na","basdn",
					"sdaklfj","asdjf","na","asdjf","na","basdn","sdaklfj","asdjf" },
		new List<string>() { "abcde", "sdaklfj", "asdjf", "na", "basdn" })); //[1, 3, 4, 3, 2]


	//ArrayManipulation
	Console.WriteLine(ArrayManipulation.arrayManipulation(10, new List<List<int>>()
{
	new List<int>() { 1, 5, 3 } ,
	new List<int>() { 4, 8, 7 } ,
	new List<int>() { 6, 9, 1 } ,
})); //10

	Console.WriteLine(ArrayManipulation.arrayManipulation(5, new List<List<int>>()
{
	new List<int>() { 1, 2, 100 } ,
	new List<int>() { 2, 5, 100 } ,
	new List<int>() { 3, 4, 100 } ,
})); //200

	//Print LinkedList
	var node = new SinglyLinkedListNode();
	node.data = 16;
	node.next = new SinglyLinkedListNode() { data = 13 };

	PrintTheElementsOfALinkedList.printLinkedList(node);

}