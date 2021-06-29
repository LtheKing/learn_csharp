<Query Kind="Program" />

void Main()
{
	Console.Write("Masukan Angka : ");
	Console.WriteLine();
	string input = Console.ReadLine();
	
	int n = Convert.ToInt32(input);
	
	for(int y = 0; y < n; y++) 
	{
		int c = 1;
		
		for(int q = 0; q < n - y; q++) {
			Console.Write("  ");
		}
		
		for(int x = 0; x <= y; x++)
		{
			Console.Write(" {0:D} ", c);
			c = c * (y -x) / (x +1);
		}
		Console.WriteLine();
		Console.WriteLine();
	}
	Console.WriteLine();
}

// Define other methods and classes here
