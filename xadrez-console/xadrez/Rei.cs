using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "R";
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
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            } 
            // nordeste
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // sudeste
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // baixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // sudoeste
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // esquerda
            pos.DefinirValores(Posicao.linha, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // noroeste
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
