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
            Console.WriteLine($"Node: {node}");
            Console.WriteLine();

            if (node.Children!.Count > 0)
            {
                foreach (var item in node.Children!)
                {
                    PrintTree(item); 
                }
            }
        }
    }
}
