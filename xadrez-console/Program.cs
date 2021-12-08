using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Tabuleiro P = new Tabuleiro(8, 8);

            P.ColocarPecas(new Torre(P, Cor.Preta), new Posicao(0, 0));
            P.ColocarPecas(new Torre(P, Cor.Preta), new Posicao(1, 9));
            P.ColocarPecas(new Rei(P, Cor.Preta), new Posicao(0, 2));

            Tela.ImprimirTabuleiro(P);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
