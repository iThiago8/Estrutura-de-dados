//um jaggedArray é também conhecido como vetor de vetores

//[][] Significa que é um vetor de vetores e neste caso [4][] quer dizer que é um um vetor de 4 posições com arrays indefinidos
int[][] numbers = new int[4][];

numbers[0] = new int[] { 1, 4, 3 };
numbers[1] = new int[] { 2, 8 };
numbers[2] = new int[] { 1, 4, 3, 10 };
numbers[3] = new int[] { 0 };
numbers[4] = null!;

//Para obter valor de jagged array
int valor = numbers[0][2];
Console.WriteLine(valor);

//Atribuir valor em um jagged array
numbers[1][2] = 35;
Console.WriteLine(numbers[1][2]);