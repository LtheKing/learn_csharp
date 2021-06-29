<Query Kind="Program" />

void Main()
{	
	Console.WriteLine("Masukan Kalimat : ");
	string str = Console.ReadLine();

	var a = Regex.Replace(str, @"[\W_]", string.Empty);
	Console.WriteLine(a);
}

// Define other methods and classes here
