using HashTable;

Product product = new();



foreach (DictionaryEntry item in shelves)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}