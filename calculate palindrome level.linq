<Query Kind="Program" />

void Main()
{
	//Sitis sit is s it is sitis 3
	//dam madam mad 2 
	// nurses run 1
	Console.WriteLine(getResult("sitissitissitissitis",0));
}

static int getResult(string word, int n) {
	int level = 0;
	int wmod,wl = 0;
	wmod = word.Length % 2;
	
	if (checkPalindrome(word))
	{
		if (wmod != 0)
		{
			word = word.Substring(0, (word.Length / 2) + 1);
			return getResult(word, n+=1);
		}
		else
		{
			word = word.Substring(0, (word.Length / 2));
			return getResult(word, n+=1);
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
