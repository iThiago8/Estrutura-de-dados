namespace ArvoreBasica
{
	public class Tree<T>
	{
		public Node<T>? Root { get; set; }
		public void PrintTree(Node<T> node)
		{
            Console.WriteLine($"Level: {node.GetHeight()}");
            Console.WriteLine($"Node: {node.Data}");
            Console.WriteLine();

			if (node.Children!.Count() > 0)
			{
				foreach (var item in node.Children!)
				{
					PrintTree(item);
				}
			}
		}
	}
}
