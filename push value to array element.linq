<Query Kind="Program" />

void Main()
{
	int[] array = {1,2,3};
	
	Array.Resize(ref array, array.Length + 1);
	array[array.GetUpperBound(0)] = 4;
	
	Console.WriteLine(array);
}

// Define other methods and classes here
