using tabuleiro;
using xadrez;


PosicaoXadrez pos = new PosicaoXadrez('a', 1);

Console.WriteLine(pos);

Console.WriteLine(pos.toPosicao()); 
// try {
//     Tabuleiro tab = new Tabuleiro(8, 8);

//     tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
//     tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
//     tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

//     Tela.imprimirTabuleiro(tab);

//     Console.ReadLine();
// }
// catch (tabuleiroException e)
// {
//     Console.WriteLine(e.Message);
// }