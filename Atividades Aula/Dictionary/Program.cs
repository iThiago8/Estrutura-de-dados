//Ao contrário do hashmap, o dictionary nos permite especificar o tipo de dado que será utilizados nos pares Key -> Value, permitindo criar uma estrutura fortemente tipada
using Dictionary;
using System.IO.Compression;

Dictionary<int, string> secretMembers = new()
{
	{1, "Daniel" },
	{2, "Gabriel" },
	{3, "Guilherme" },
	{4, "Gustavo" },
	{5, "Igor" },
	{6, "Mauricio" },
	{7, "Thiago" },
	{8, "Vinicius" },
};
/*
try
{
	string member = secretMembers[9];
}
catch
{
	Console.WriteLine("Membro não encontrado");
}

if (secretMembers.ContainsKey(3))
	Console.WriteLine($"Valor da chave 3: {secretMembers[3]}");

foreach (var kvp in secretMembers)
	Console.WriteLine();
*/

Dictionary<int, Pessoa> dicPessoa = [];
dicPessoa.Add(
	1,
	new Pessoa()
	{
		Id = 0,
		BirthDate = new DateTime(2005, 3, 31),
		Name = "Thiago"
	}
);

dicPessoa.Add(
	2,
	new Pessoa()
	{
		Id = 1,
		BirthDate = new DateTime(2004, 7, 16),
		Name = "Gabriel"
	}
);

foreach (var pessoa in dicPessoa)
    Console.WriteLine($"{pessoa.Key}:{pessoa.Value.Name}:{pessoa.Value.BirthDate}");

