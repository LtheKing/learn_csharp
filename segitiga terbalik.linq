<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Masukan jumlah bintang : ");
	int n = Convert.ToInt32(Console.ReadLine());
	
	bentukBintang(n);
}

static void bentukBintang(int n) {
	int a = n;
	for(int i = 0; n > i; i++){
		for (int j = a; j > 0; j--)
		{
			Console.Write("$");
		}
		Console.WriteLine();
		a--;
	}
}

// Define other methods and classes here
