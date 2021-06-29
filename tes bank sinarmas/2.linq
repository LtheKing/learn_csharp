<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Masukkan Nilai Faktorial : ");
	
	int param = Convert.ToInt32(Console.ReadLine()); 
	var result = factorial_Recursion(param);
	Console.WriteLine("Nilai Desimalnya adalah : "+ result);
}	

public static double factorial_Recursion(int number)
{
	if (number == 1)
		return 1;
	else
		return number * factorial_Recursion(number - 1);
}

// Define other methods and classes here
