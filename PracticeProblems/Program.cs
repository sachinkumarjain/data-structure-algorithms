using System;
using System.Collections.Generic;
using System.Linq;

public class GFG
{
	static public void Main()
	{
		//var t = Convert.ToInt32(Console.ReadLine());
		//var n1 = Console.ReadLine().Split(' ');
		//var arr1 = Console.ReadLine().Split(' ');
		//var n2 = Console.ReadLine().Split(' ');
		//var arr2 = Console.ReadLine().Split(' ');
		//var arr = new[] { arr1.Select(int.Parse).ToArray(), arr2.Select(int.Parse).ToArray() };
		//var sum = new[] { Convert.ToInt32(n1[1]), Convert.ToInt32(n2[1]) };

		//for (int j = 0; j < t; j++)
		//{
		//	PairwithSum(arr[j], sum[j]);
		//	//Console.WriteLine(result);
		//}

		int[] input = { 5, 6, 1, 2, 3, 4 };
		//int[] input = { 5, 6, 1, 2, 3, 4 };
		var minElement = FindMin(input);

		Console.WriteLine(minElement == 1 ? "passed" : "failed");
	}

	private static int? FindMin(int[] a)
	{
		int n = a.Length;
		int mid = (n / 2) - 1;
		int p1 = 0;
		int p2 = n - 1;

		while(p1 <= mid && p2 >= mid)
		{
			Console.WriteLine($"a[p1] < a[mid] > {a[p1]} < {a[mid]}");
			Console.WriteLine($"a[p2] < a[mid] > {a[p2]} < {a[mid]}");
			if (a[p1] > a[mid]) p1++; else return a[--p1];
			if (a[p2] < a[mid] ) p2--; else return a[++p2];
		}
		return null;
	}

	public static void PairwithSum(int[] arr, int sum)
	{
		int low = 0;
		int high = arr.Length - 1;

		while (low < high)
		{
			if (arr[low] + arr[high] == sum)
			{
				Console.WriteLine("The pair is : ("
								+ arr[low] + ", " + arr[high] + ")");
			}
			if (arr[low] + arr[high] > sum)
			{
				high--;
			}
			else
			{
				low++;
			}
		}
		//var comp = new HashSet<int>();
		//var count = 0;
		//for (int i = 0; i < a.Length; i++)
		//{
		//	if (comp.Contains(a[i]))
		//	{
		//		count++;
		//	}
		//	comp.Add(k - a[i]);
		//}
		//return count;
	}
}