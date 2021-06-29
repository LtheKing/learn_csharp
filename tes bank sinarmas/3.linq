<Query Kind="Program" />

void Main()
{
	int tahun;
	Console.Write("Masukkan tahun: ");
	Console.WriteLine();
	tahun = Convert.ToInt16(Console.ReadLine());
	if (tahun % 400 == 0)
	{
		Console.Write(tahun + " Merupakan Tahun Kabisat\n");
	}
	else if (tahun % 100 == 0)
	{
		Console.Write(tahun + " Bukan Tahun Kabisat\n");
	}
	else if (tahun % 4 == 0)
	{
		Console.Write(tahun + " Merupakan Tahun Kabisat\n");
	}
	else
	{
		Console.Write(tahun + " Bukan Tahun Kabisat\n");
	}
}

// Define other methods and classes here
