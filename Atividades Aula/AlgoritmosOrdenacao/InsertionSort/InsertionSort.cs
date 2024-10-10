using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
	public static class InsertionSort
	{
		public static T[] Sort<T>(T[] arr) where T : IComparable
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int j = i;
				while (j > 0 && arr[j].CompareTo(arr[j - 1]) < 0)
				{
					Swap(arr, j, j - 1);
					j--;
				}
			}
			return arr;
		}
		public static void Swap<T>(T[] arr, int first, int second)
		{
			(arr[first], arr[second]) = (arr[second], arr[first]);
		}
		public static void PrintArr<T>(T[] arr)
		{
			foreach (T item in arr)
                Console.Write($"{item} ");

            Console.WriteLine();
		}
		
	}
}
