﻿using HackerRankProblems.Tests.Easy;
using ProblemSolving_HackerRank_;
using ProblemSolving_HackerRank_.Easy;
using ProblemSolving_HackerRank_.Hard;
using ProblemSolving_HackerRank_.Medium;

CountApplesAndOranges();
//TryAll();
static void TryAll()
{
	#region Easy Problems
	simpleArraySum();

	compareTriplets();

	aVeryBigSum();

	diagonalDifference();

	plusMinus();

	stairCase();

	miniMaxSum();

	timeConversion();

	dayOfProgrammer();

	billDivision();

	printLinkedList();

	maximumElement();

	equalStacks();

	gradingStudents();

	pickingNumbers();

	catsAndMouse();

	#endregion

	#region Medium Problems
	sparseArray();
	balancedBrackets();
	#endregion

	#region Hard Problems
	arrayManipulation(); 
	#endregion
}

#region The Static Function

#region Easy Problems
static void simpleArraySum()
{
	//Simple Array Sum
	Console.WriteLine(SimpleArraySum.simpleArraySum(new List<int>() { 1, 2, 3, 4, 10, 11 })); //31
}

static void compareTriplets()
{
	//Compare the Triplets
	Helper.PrintList(CompareTheTriplets.compareTriplets(new List<int>() { 17, 28, 30 },
															 new List<int>() { 99, 16, 8 }
															 )); //[2, 1]
}

static void aVeryBigSum()
{
	//A Very Big Sum
	Console.WriteLine(
			AVeryBigSum.aVeryBigSum(new List<long>()
			{ 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }
									)); //5000000015
}

static void diagonalDifference()
{
	//Diagonal Difference
	var SquareMatrix = new List<List<int>>()
	{
		new List<int>(){1, 2, 3},
		new List<int>(){4, 5, 6},
		new List<int>(){9, 8, 9},
	};

	Helper.PrintSquareMatrix(SquareMatrix);
	Console.WriteLine(DiagonalDifference.diagonalDifference(SquareMatrix)); //2
}

static void plusMinus()
{
	//Plus Minus
	PlusMinus.plusMinus(new List<int>() { -4, 3, -9, 0, 4, 1 });
}

static void stairCase()
{
	//Staircase
	Staircase.staircase(10);
}

static void miniMaxSum()
{
	//Min Max Sum
	MiniMaxSum.miniMaxSum(
	   new List<int>()
	   { 256741038, 623958417, 467905213, 714532089, 938071625 }); //2063136757 2744467344
}

static void timeConversion()
{
	//Time Conversion
	Console.WriteLine(TimeConversion.timeConversion("12:01:00PM"));
	Console.WriteLine(TimeConversion.timeConversion("05:01:00PM"));
	Console.WriteLine(TimeConversion.timeConversion("12:01:00AM"));
	Console.WriteLine(TimeConversion.timeConversion("01:01:00AM"));
}

static void dayOfProgrammer()
{
	//Day of the programmer
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(1984)); //12.09.1984
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(2017)); //13.09.2017
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(1800)); //12.09.1984
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(2016)); //12.09.2017
	Console.WriteLine(DayOfTheProgrammer.dayOfProgrammer(1918)); //26.09.2017
}

static void billDivision()
{
	//Bill Division
	BillDivision.bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 12);
	BillDivision.bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 7);
}

static void printLinkedList()
{
	//Print LinkedList
	var node = new SinglyLinkedListNode();
	node.data = 16;
	node.next = new SinglyLinkedListNode() { data = 13 };

	PrintTheElementsOfALinkedList.printLinkedList(node);
}

static void maximumElement()
{
	//Maximum Element
	MaximumElement.getMax(
		   new List<string>()
		   {
		   "1 97","2","1 20","2","1 26","1 20","2","3","1 91","3"
		   });
}

static void equalStacks()
{
	Console.WriteLine(EqualStacks.equalStacks(
		 new List<int>() { 3, 2, 1, 1, 1 },
		 new List<int>() { 4, 3, 2 },
		 new List<int>() { 1, 1, 4, 1 }
	)); //5
}

static void gradingStudents()
{
	Helper.PrintList(GradingStudents.gradingStudents(new List<int> { 73, 67, 38, 33 }));
}

static void pickingNumbers()
{
    Console.WriteLine(PickingNumbers.pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 })); //should be 3
    Console.WriteLine(PickingNumbers.pickingNumbers(new List<int> { 1, 2, 2, 3, 1, 2 })); //should be 5
    Console.WriteLine(PickingNumbers.pickingNumbers(
		 new List<int> 
		 { 
			 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 
			 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 
			 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4, 
		 })); //should be 22
}

static void catsAndMouse()
{
    Console.WriteLine(CatsAndAMouse.catAndMouse(2, 5, 4)); //Cat B
    Console.WriteLine(CatsAndAMouse.catAndMouse(1, 2, 3)); //Cat B
    Console.WriteLine(CatsAndAMouse.catAndMouse(1, 3, 2)); //Mouse C
}

static void CountApplesAndOranges()
{
	AppleAndOrange.countApplesAndOranges(7, 10, 4, 12, new List<int>() { 2, 3, -4 }, new List<int>() { 3, -2, -4 });
}
#endregion

#region Medium Problems
static void sparseArray()
{
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
} 

static void balancedBrackets()
{
	Console.WriteLine(BalancedBrackets.isBalanced("{[()]}"));			//YES
	Console.WriteLine(BalancedBrackets.isBalanced("{[(])}"));			//NO
	Console.WriteLine(BalancedBrackets.isBalanced("{{[[(())]]}}"));  //YES
}
#endregion

#region Hard Problems
static void arrayManipulation()
{
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
}
#endregion

#endregion