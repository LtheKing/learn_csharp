<Query Kind="Program" />

void Main()
{
	if (checkPalindrome("string"))
	{
		Console.WriteLine("yes");
	} else {
		Console.WriteLine("Oh No");
	}
}

bool checkPalindrome(string n)
{
	string _reversestr = string.Empty;
	bool result;
	if (n != null)
	{
		for (int i = n.Length - 1; i >= 0; i--)
		{
			_reversestr += n[i].ToString();
		}
		if (_reversestr == n)
		{
			result = true;
		}
		else
		{
			result = false;
		}
		return result;
	}
	
	return result = true;
}


