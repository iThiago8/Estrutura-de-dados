using ArvoreBinariaCargos;

Tree<Person> tree = new Tree<Person>();
tree.Root = new Node<Person>()
{
	Data = new Person
	{
		Name = "Thiago Pedro Padilha",
		Role = "CEO"
	}
};

tree.Root.Children = new List<Node<Person>>()
{
	new Node<Person>
	{
		Data = new Person
		{
			Name = "Gabriel Ceron Bianchi",
			Role = "Gerente de Desenvolvimento"
		}
	},
	new Node<Person>
	{
		Data = new Person
		{
			Name = "Vinicius Schaedler",
			Role = "Gerente de Engenharia"
		}
	},
	new Node<Person>
	{
		Data = new Person
		{
			Name = "Marcos Henrique Vermolhen",
			Role = "Gerente de Segurança"
		}
	}
};