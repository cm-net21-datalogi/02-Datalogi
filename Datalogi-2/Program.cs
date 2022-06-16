
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

for (int i = 1; i < 50; i++)
{
	Stopwatch watch = Stopwatch.StartNew();
	var result = Fibonacci(i);
	watch.Stop();
	Console.WriteLine(i + "th Fibonacci number: " + result
		+ "     After " + (watch.ElapsedMilliseconds / 1000) + " seconds.");
}
