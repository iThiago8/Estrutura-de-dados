using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
	public static class BubbleSort
	{
		public static void Sort<T>(T[] arr) where T : IComparable
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - 1; j++)
				{
					if (arr[j].CompareTo(arr[j + 1]) > 0)
					{
						Swap(arr, j, j + 1);
					}
				}
			}
		}
		public static void Swap<T>(T[] arr, int first, int second)
		{
			T temp = arr[first];
			arr[first] = arr[second];
			arr[second] = temp;
		}
		public static void PrintArr<T>(T[] arr)
		{
            Console.Write('[');
			foreach (T item in arr)
			{
                Console.Write($" {item} ");
			}
            Console.Write(']');
            Console.WriteLine();
		}
	}
}