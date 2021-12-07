using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro P = new Tabuleiro(8, 8);

            P.ColocarPecas(new Torre(P, Cor.Preta), new Posicao(0, 0));
            P.ColocarPecas(new Torre(P, Cor.Preta), new Posicao(1, 3));
            P.ColocarPecas(new Rei(P, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(P);
        }
    }
}
