<Query Kind="Program" />

void Main()
{
	string _inputstr, _reversestr = string.Empty;
	Console.Write("Masukkan Kata : ");
	Console.WriteLine();
	_inputstr = Console.ReadLine();
	if (_inputstr != null)
	{
		for (int i = _inputstr.Length - 1; i >= 0; i--)
		{
			_reversestr += _inputstr[i].ToString();
		}
		if (_reversestr == _inputstr)
		{
			Console.WriteLine("Kata {0} Merupakan Palindrome", _inputstr);
		}
		else
		{
			Console.WriteLine("Kata {0} Bukan Merupakan Palindrome", _inputstr);
		}
	}
}

// Define other methods and classes here