<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>System.Collections</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.IO</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Reflection</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Text</Namespace>
  <Namespace>System.Text.RegularExpressions</Namespace>
</Query>

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
		var de = new List<int>();
		var factorial = 0;
		var s = a[1];
		
		for (int i = 1; i <= a[1]; i++)
		{
			de.Add(s);
			s += a[1];
		}
		
		for (int i = 0; i < a[1]; i++)
		{			
			var res = false;
			
			foreach (var x in b)
			{
				if (x % de[i] == 0) {
					res = true;
				} else {
					res = false;
					break;
				}
			}
			
			if (res)
			{
				factorial += 1;
			}
		}
		
		return factorial;
		
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

		List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

		List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

		int total = Result.getTotalX(arr, brr);

		Console.WriteLine(total);
	}
}
