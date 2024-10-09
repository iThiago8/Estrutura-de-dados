using HashTable;
using System.Collections;

Random random = new();

string[] merchandises = { "Banana", "Batata", "Macarrão", "Leite", "Sabonete", "Salsicha", "Beringela", "Abobrinha" };

Hashtable shelves = [];
Queue<Product> products = [];

for (int i = 0; i < 27;)
{
    products.Enqueue(new Product()
    {
        Id = ++i,
        Name = merchandises[random.Next(0, 7)]
    });
}

for (int i = 1; i < 10; i++)
{
    shelves.Add(products.Dequeue(), $"A{i}");
    shelves.Add(products.Dequeue(), $"B{i}");
    shelves.Add(products.Dequeue(), $"C{i}");
}

foreach (DictionaryEntry p in shelves)
{
    Console.WriteLine($"{p.Key.ToString()} - {p.Value}");
}

Console.WriteLine("Escreva o código do produto");
bool parsing = false;
int productId = 0;

while(!parsing)
{
    parsing = int.TryParse(Console.ReadLine(), out productId);
    if (!parsing)
        Console.WriteLine("Favor inserir um valor válido");
}

Product keyToFind = new() { Id = productId };
if (shelves[keyToFind] != null)
    Console.WriteLine($"O produto está na prateleira: {shelves[keyToFind]}");
else
    Console.WriteLine($"O produto não foi encontrado");

