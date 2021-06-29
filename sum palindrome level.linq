<Query Kind="Program" />

void Main()
{
	//sitissitissitissitis
	//Sitis sit is s it is sitis 7
	//dam madam mad 3
	// nurses run 1
	Console.WriteLine(getResult("nurses run", 0));
}

static int getResult(string word, int n)
{
	int wl = word.Length;
	
	for (int i = 1; i <= wl; i++)
	{
		string w = word.Substring(0, i);
		if (checkPalindrome(w))
		{
			//word = word.Substring(w.Length, word.Length - w.Length);
			n +=1;
		}
	}

	return n;
}

static bool checkPalindrome(string n)
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


// Define other methods and classes here
