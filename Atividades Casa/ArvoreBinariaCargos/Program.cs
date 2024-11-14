using ArvoreBinariaCargos;

Tree<Person> company = new Tree<Person>();
company.Root = new Node<Person>()
{
    Data = new Person(1, "Thiago Pedro Padilha", "CEO"),
    Parent = null
};

company.Root.Children = new List<Node<Person>>()
{
    new Node<Person>
    {
        Data = new Person(2, "Gabriel Ceron Bianchi", "Head of Development"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(3, "Vinicius Schaedler", "Head of Engineering"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(4, "Marcos Henrique Vermolhen", "Head of Security"),
        Parent = company.Root
    },
};
company.Root.Children[0].Children = new List<Node<Person>>()
{ 
    new Node<Person>
    {
        Data = new Person(5, "Paulo Turco", "Senior Developer"),
        Parent = company.Root
    },

    new Node<Person>
    {
        Data = new Person(7, "Jonatan Moreira", "Junior Developer"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(9, "Victor Cassanego", "Developer Intern"),
        Parent = company.Root
    }
};
company.Root.Children[1].Children = new List<Node<Person>>()
{
    new Node<Person>
    {
        Data = new Person(6, "Guilherme Perazzoli", "Senior engineer"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(8, "Vinicius Bocca", "Senior engineer"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(11, "Junior dos Santos", "Junior engineer"),
        Parent = company.Root
    }
};
company.Root.Children[2].Children = new List<Node<Person>>()
{
    new Node<Person>
    {
        Data = new Person(10, "Igor de Oliveira", "Senior security"),
        Parent = company.Root
    }
};
