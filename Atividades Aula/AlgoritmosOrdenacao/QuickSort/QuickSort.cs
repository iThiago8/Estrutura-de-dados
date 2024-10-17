using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
	public class QuickSort
	{
		public static T[] Sort<T>(T[] arr, int lower, int upper) where T : IComparable
		{
			if (lower < upper)
			{
				if (lower < upper)
				{
					int p = Partition(arr, lower, upper);
					Sort(arr, lower, p);
					Sort(arr, p + 1, upper);
				}
			}

			return arr;
		}

		public static int Partition<T>(T[] arr, int lower, int upper) where T : IComparable
		{
			int i = lower;
			int j = upper;
			T pivot = arr[lower];

			do
			{
				while (arr[i].CompareTo(pivot) < 0) { i++; } 
				while (arr[j].CompareTo(pivot) > 0) { j--; }
				
				if (i <= j)
					break;

				Swap(arr, i, j);
			}
			while ( i <= j);

			return j;
		}
		public static void Swap<T>(T[] arr, int first, int second)
		{
			(arr[first], arr[second]) = (arr[second], arr[first]);
		}
	}
}
