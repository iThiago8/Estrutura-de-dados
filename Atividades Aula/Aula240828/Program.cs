List<int> numerosPares = [];
List<int> numerosImpares = [];

for (int i = 0; numerosPares.Count <= 100 && numerosImpares.Count <= 100;  i++)
{
    if (i % 2 == 0)
    {
        numerosPares.Add(i);
    }
    else
    {
        numerosImpares.Add(i);
    }
}

Console.Write("Números pares: ");
foreach (var i in  numerosPares)
    Console.Write($"{i}, ");

Console.WriteLine();
Console.WriteLine();
Console.Write("Números ímpares: ");
foreach (var i in numerosImpares)
    Console.Write($"{i}, ");

