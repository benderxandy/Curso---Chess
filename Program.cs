using tabuleiro;
using xadrez;


// PosicaoXadrez pos = new PosicaoXadrez('a', 1);

// Console.WriteLine(pos);

// Console.WriteLine(pos.toPosicao()); 
try {
    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);
    }



}
catch (tabuleiroException e)
{
    Console.WriteLine(e.Message);
}