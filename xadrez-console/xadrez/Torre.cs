using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
        private bool PodeMover(Posicao _pos)
        {
            Peca p = Tabuleiro.Peca(_pos);
            return p == null || p.Cor != this.Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            // acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha = pos.linha--;
            }
            // nordeste

            // direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna = pos.coluna++;
            }
            // sudeste

            // baixo
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha = pos.linha++;
            }
            // sudoeste

            // esquerda
            pos.DefinirValores(Posicao.linha, Posicao.coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna = pos.coluna--;
            }
            // noroeste

            return mat;
        }
    }
}