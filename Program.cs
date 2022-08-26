using tabuleiro;
using xadrez;


// PosicaoXadrez pos = new PosicaoXadrez('a', 1);

// Console.WriteLine(pos);

// Console.WriteLine(pos.toPosicao()); 
try {
    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.terminada)
    {
        try
        {
            Console.Clear();
            Tela.imprimirPartida(partida);

            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaodeOrigem(origem);

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);    

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicacaodeDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }
        catch (tabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
}
catch (tabuleiroException e)
{
    Console.WriteLine(e.Message);
}