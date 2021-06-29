<Query Kind="Program" />

void Main()
{
	Console.WriteLine("===== Convert to Detail ==============");
	Console.WriteLine("Masukan Detik : ");
	int secon = Convert.ToInt32(Console.ReadLine());
	convert(secon);
	
	Console.WriteLine("====== Reverse Detail ========");
	Console.WriteLine("Masukan Jam : ");
	int jam = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Masukan Jam : ");
	int menit = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Masukan Jam : ");
	int detik = Convert.ToInt32(Console.ReadLine());
	
	reverse(jam,menit,detik);
}

public void convert(int n) {
	n = n % (24 * 3600);
	int hour = n / 3600;

	n %= 3600;
	int minutes = n / 60;

	n %= 60;
	int seconds = n;
	
	Console.WriteLine(hour + " jam " + minutes + " menit " + seconds + " detik ");
}

void reverse(int jam, int menit, int detik)
{
	int o_jam = jam * 3600;
	int o_menit = menit * 60;
	int result = o_jam + o_menit + detik;
	Console.WriteLine(result);
}

// Define other methods and classes here
