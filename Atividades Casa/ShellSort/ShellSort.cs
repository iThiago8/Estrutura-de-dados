using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
	public class ShellSort
	{
		public static void Sort<T>(T[] array) where T : IComparable
		{
			int n = array.Length;

			for (int gap = n / 2; gap > 0; gap /= 2)
			{
				for (int i = gap; i < n; i++)
				{
					T temp = array[i];
					int j;
					for (j = i; j >= gap && array[j - gap].CompareTo(temp) > 0; j -= gap)
					{
						array[j] = array[j - gap];
					}
					array[j] = temp;
					foreach (var item in array)
						Console.Write($"{item} ");
                    Console.WriteLine();
				}
			}
		}

	}
}

