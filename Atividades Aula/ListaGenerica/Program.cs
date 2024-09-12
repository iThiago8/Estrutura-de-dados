using ListaGenerica;
using System.Security.Cryptography;

List<double> numbers = [];
/*
do
{
    Console.WriteLine("Insira um número");
    string? numberStr = Console.ReadLine();
    //Validando a entrada do usuário
    if (!double.TryParse(numberStr, out double number))
    {
        break;
    }
    
    numbers.Add(number);
}
while (true);

Console.WriteLine($"A média dos valores é {numbers.Average()}");
*/
List<Person> people = [];
Person p1 = new();
p1.Name = "Gadeia japinha";
p1.Age = 5;
p1.Country = CountryEnum.JP;
people.Add(p1);

people.Add(new Person()
{
    Name = "Vinizao canadense",
    Age = 19,
    Country = CountryEnum.CA
});

Person p3 = new Person()
{
    Name = "Danizao paraguaio",
    Age = 12,
    Country = CountryEnum.PY
};
people.Add(p3);

//Formas de percorrer a lista genérica

foreach (var p in people)
{
    Console.WriteLine(p.Name);
}
