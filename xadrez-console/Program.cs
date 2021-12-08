using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez p = new PosicaoXadrez('c', 7);
            Console.WriteLine(p);
            Console.WriteLine(p.ToPosicao());

            Console.ReadLine();
        }
    }
}
