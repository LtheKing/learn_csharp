<Query Kind="Program" />

void Main()
{
	create(6, 1);
}

void create(int n, int b) {
	for (int i = 1; i < n; i++)
	{
		Console.Write(" ");
	}
	
	for (int i = 0; i < b; i++)
	{
		Console.Write("#");
	}

	Console.WriteLine();

	if (n > 1)
	{
		create((n - 1), (b + 1));
	}
}

// Define other methods and classes here
