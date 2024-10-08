using HashTable;
using System.Collections;

Random random = new();

string[] merchandises = { "Banana", "Batata", "Macarrão", "Leite", "Sabonete", "Salsicha", "Beringela", "Abobrinha" };

Hashtable shelves = [];
Queue<Product> products = [];

for (int i = 0; i < 99; i++)
{
    products.Enqueue(new Product()
    {
        Id = ++i,
        Name = merchandises[random.Next(0, 7)]
    });

}

for (int i = 1; i < 10; i++)
{
    shelves.Add($"A{i}", products.Dequeue());
    shelves.Add($"B{i}", products.Dequeue());
    shelves.Add($"C{i}", products.Dequeue());
}

foreach (DictionaryEntry item in shelves)
{
    Console.WriteLine($"{item.Key} - {item.Value?.ToString()}");
}