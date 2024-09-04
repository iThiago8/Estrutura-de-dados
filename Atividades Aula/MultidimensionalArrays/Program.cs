//Criando um vetor multidimensaional com 5 linhas e 2 colunas
 

int[,] numbers = new int[5, 2];

//Vetor tridimensional 
int[,,] triNumbers = new int[5, 2, 3];

//Podemos inicializar os valores do vetor no momento de sua declaração
int[,] iniNumbers = new int[,]
{
    {10, 40, 5},
    {10, 1, 4},
    {66, 4, 3},
    {10, 41, 9},
};

int linhaMaiorValor = 0;
int colunaMaiorValor = 0;
int maiorValor = 0;

for (int i = 0; i < iniNumbers.GetLength(0); i++)
{
    for (int j = 0; j < iniNumbers.GetLength(1); j++)
    {
        if (maiorValor < iniNumbers[i, j])
        {
            maiorValor = iniNumbers[i, j];
            linhaMaiorValor = i;
            colunaMaiorValor = j;
        }

    }
}

Console.WriteLine($"Maior valor: {maiorValor}");
Console.WriteLine($"Linha do maior valor: {linhaMaiorValor}");
Console.WriteLine($"Coluna do maior valor: {colunaMaiorValor}");