using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePilha.Data
{
	public class DataSet
	{
		Stack<int> AvailableNumbers { get; set; } = [];
		Queue<int> NumbersToCall { get; set; } = [];
		List<int> CalledNumbers { get; set; } = [];

		public void GenerateNumbers()
		{
            for (int i = 15; i > 0; i--)
            {
				AvailableNumbers.Push(i);
            }
        }
	}
}
