<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Masukkan Kata / Kalimat : ");
	string str = Console.ReadLine();	

	Console.WriteLine("String: " + str);
	int jumlah = 0;
	while (str.Length > 0)
	{
		Console.Write(str[0] + " = ");
		int cal = 0;

		for (int j = 0; j < str.Length; j++)
		{
			if (str[0] == str[j])
			{
				cal++;
			}
		}
		
		jumlah += cal;
		Console.WriteLine(cal);
		str = str.Replace(str[0].ToString(), string.Empty);
	}
	
	Console.WriteLine("Jumlah Huruf Yang Terpakai : " + jumlah);
	Console.ReadLine();
}

// Define other methods and classes here
