using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro _tab)
        {
            for (int i = 0; i < _tab.Linhas; i++)
            {
                for (int j = 0; j < _tab.Colunas; j++)
                {
                    if (_tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                    Console.Write(_tab.Peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
