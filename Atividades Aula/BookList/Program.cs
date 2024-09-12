using BookList;

List<Book> ThroneOfGlass = [];

ThroneOfGlass.Add(new Book()
{
    Name = "Throne of Glass",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 432
});

ThroneOfGlass.Add(new Book()
{
    Name = "Crown of Midnight",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 448
});

ThroneOfGlass.Add(new Book()
{
    Name = "Heir of Fire",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 592
});

ThroneOfGlass.Add(new Book()
{
    Name = "Queen of Shadows",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 672
});

ThroneOfGlass.Add(new Book()
{
    Name = "Empire of Storms",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 720
});

ThroneOfGlass.Add(new Book()
{
    Name = "Tower of Dawn",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 688
});

ThroneOfGlass.Add(new Book()
{
    Name = "Kingdom of Ash",
    Publisher = "Bloomsbury",
    Author = "Sarah J. Maas",
    Pages = 992
});


foreach (var book in ThroneOfGlass)
{
    Console.WriteLine($"Name: {book.Name}");
    Console.WriteLine($"Publisher: {book.Publisher}");
    Console.WriteLine($"Author: {book.Author}");
    Console.WriteLine($"Número de páginas: {book.Pages}");
    Console.WriteLine("---------------------------------");
    Console.WriteLine();
}

Book longestBook = new();
Console.WriteLine("***********");
Console.WriteLine("MAIOR LIVRO");
Console.WriteLine("***********");

foreach (var book in ThroneOfGlass)
{
    if (book.Pages > longestBook.Pages)
        longestBook = book;
}

Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine($"Name: {longestBook.Name}");
Console.WriteLine($"Publisher: {longestBook.Publisher}");
Console.WriteLine($"Author: {longestBook.Author}");
Console.WriteLine($"Número de páginas: {longestBook.Pages}");
Console.WriteLine("---------------------------------");
Console.WriteLine();