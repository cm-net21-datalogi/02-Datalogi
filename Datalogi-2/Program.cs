
//int f4 = Factorial(4);
//Console.WriteLine("4! == " + f4);
// Facit: 4 * 3 * 2 * 1 == 4 * 6 == 24

using System.Diagnostics;

static int Factorial(int n)
{
	if (n <= 1)
		return 1;
	return n * Factorial(n - 1);
}

static void PrintUpTo(int max)
{
	/*if(max < 1)
	{
		return;
	}
	else*/
	if(max > 0)
	{
		PrintUpTo(max - 1);
		Console.WriteLine(max);
	}
}

//PrintUpTo(7);


//double result = CalculateInterest(100, 50);
//Console.WriteLine("Balance after 50 year is " + result);


static double CalculateInterest(double balance, int years)
{
	const double interestRate = 0.05;
	double interestThisYear = balance * interestRate;

	if(years == 1)
	{
		return balance + interestThisYear;
	}
	else
	{
		double newBalance = balance + interestThisYear;
		return CalculateInterest(newBalance, years - 1);
	}
}



static int ArraySum(int[] array, int startIndex = 0)
{
	if (startIndex == array.Length - 1)
	{
		return array[startIndex];
	}
	else
	{
		return array[startIndex] + ArraySum(array, startIndex + 1);
	}
}

//int[] testArray = new int[] { 2, 3, 5 };
//int sum = ArraySum(testArray);
//Console.WriteLine("Sum of test array is: " + sum);



static long Fibonacci(long n)
{
	if (n <= 1)
		return 0;
	else if (n == 2)
		return 1;

	return Fibonacci(n - 1) + Fibonacci(n - 2);
}

/*
for (int i = 1; i < 50; i++)
{
	Stopwatch watch = Stopwatch.StartNew();
	var result = Fibonacci(i);
	watch.Stop();
	Console.WriteLine(i + "th Fibonacci number: " + result
		+ "     After " + (watch.ElapsedMilliseconds / 1000) + " seconds.");
}
*/


static void PrintEven(int min, int max)
{
	// max < min
	// min == max
	// max <= min
	// max == min + 1
	if (max < min)
	{
		return;
	}
	PrintEven(min, max - 1);
	if (max % 2 == 0)
		Console.WriteLine(max);
}

/*
Console.WriteLine("Print even 17,17");
PrintEven(17, 17);

Console.WriteLine("Print even 24,27");
PrintEven(24, 27);
*/


static string Reverse(string s)
{
	if(s == "")
	{
		return "";
	}
	else if (s.Length == 1)
	{
		return s;
	}
	else
	{
		char firstLetter = s[0];
		return Reverse(s.Substring(1)) + firstLetter;
	}
}

// Console.WriteLine("Reverse: " + Reverse("reverse"));

static bool IsPalindrom(string candidate)
{
	// Enkla lösningen
	// return s == Reverse(s
	// 

	if (candidate.Length <= 1)
	{
		return true;
	}
	else if(candidate.Length == 2)
	{
		return candidate[0] == candidate[1];
	}
	char first = candidate[0];
	char last = candidate[candidate.Length - 1];
	string middle = candidate.Substring(1, candidate.Length - 2);
	if (first != last)
		return false;

	return IsPalindrom(middle);
}

Console.WriteLine(IsPalindrom(""));
Console.WriteLine(IsPalindrom("x"));
Console.WriteLine(IsPalindrom("yy"));
Console.WriteLine(IsPalindrom("apa"));
Console.WriteLine(IsPalindrom("abba"));

Console.WriteLine(IsPalindrom("nope"));
Console.WriteLine(IsPalindrom("april"));
