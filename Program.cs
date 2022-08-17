using tabuleiro;

Tabuleiro tab = new Tabuleiro(8, 8);

Tela.imprimirTabuleiro(tab);

Console.ReadLine();

int[,] mat = new int[8,8];

for (int i = 0; i<8; i++)
{
    for (int j = 0; j<8; j++)
    {
        Console.WriteLine(mat[i, j]);
    }
}

