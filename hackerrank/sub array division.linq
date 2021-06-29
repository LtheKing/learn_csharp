<Query Kind="Program" />

void Main()
{
	int n = Convert.ToInt32(Console.ReadLine().Trim());

	List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

	string[] dm = Console.ReadLine().TrimEnd().Split(' ');

	int d = Convert.ToInt32(dm[0]);

	int m = Convert.ToInt32(dm[1]);

	int result = birthday(s, d, m);
	
	Console.WriteLine(result);

}

static int birthday(List<int> s, int d, int m)
{
	var result = 0;
	var balance = 0;
	
	for (int i = 0; i < s.Count(); i++)
	{				
		if (i == (s.Count() - 1))
		{
			break;
		}
		
		for (int x = 0; x < m; x++)
		{
			balance += s[x + i];
			//if (x == (m - 1)) 
			//{
			//	break;
			//}
			
			if (balance == d) {
				result++;
			}
		}
		balance = 0;
	}

	return result;
}


// Define other methods and classes here
