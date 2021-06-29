<Query Kind="Program" />

void Main()
{
	create(10, "b");
}

void create(int n, string type) {
	if (type == "a")
	{
		Console.WriteLine("*");
	} else {
		Console.WriteLine();
		for (int i = 0; i < n; i++)
		{
			Console.Write("#");
		}
		
		create(n-1, "b");
	}
}

// Define other methods and classes here
