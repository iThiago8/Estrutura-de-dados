using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaCargos
{
	public class Tree<T>
	{
        public  Node<T>? Root { get; set; }
		public void PrintTree(Node<T> node)
		{
            Console.WriteLine("");
		}
    }
}
