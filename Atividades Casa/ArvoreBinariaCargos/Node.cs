using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaCargos
{
	public class Node<T>
	{
		public T? Data { get; set; }
		
		public Node<T>? Parent { get; set; }
		
		public List<Node<T>>? Children { get; set; } = [];

		public int GetHeight()
		{
			int index = 0;
			Node<T> current = this;
			while (current.Parent != null)
			{
				index++;
				current = current.Parent;
			}
			return index;
		}

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}
