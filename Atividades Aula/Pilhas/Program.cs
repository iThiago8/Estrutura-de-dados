/*
  As pilhas trabalham com uma estrutura LIFO (Last in First out)
  Três métodos importantes:
    Push(): insere um elemento no topo da pilha
    Pop(): remove um elemento do topo da pilha e o retorna
    Peek(): retorna o elemento do topo da pilha sem removê-lo
 */

// Invertendo as bolas

/*
Stack<char> caracteres = new Stack<char>();
foreach (char c in "Gui do Pé Frio")
    caracteres.Push(c);
*/
//Desempilhando

//Utilizando o conceito de pilha com os métodos pop e push, escreva um programa que leia uma entrada e identifique se a palavra é um palíndromo ou não
/*
string invertido = string.Empty;
while (caracteres.Count > 0)
{
    invertido += caracteres.Pop();
}

Console.WriteLine(invertido);
*/


Console.WriteLine("Insira uma palavra para ver se ela é um palíndromo");
string? word = Console.ReadLine();
Stack<char> chars = new Stack<char>();
string? drow = string.Empty;

foreach (char c in word)
{
    chars.Push(c);
}


while (chars.Count > 0)
{
    drow += chars.Pop();
}

word = word.TrimEnd();
drow = drow.TrimStart();

if (word.ToLower() == drow.ToLower())
    Console.WriteLine($"{word} é um palíndromo");
else
    Console.WriteLine($"{word} não é um palíndromo");

