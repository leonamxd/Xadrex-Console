namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas { get; set; }
        public Tabuleiro()
        {
        }
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca Peca(int _linha, int _coluna)
        {
            return Pecas[_linha, _coluna];
        }
        public Peca Peca(Posicao _pos)
        {
            return Pecas[_pos.linha, _pos.coluna];
        }
        public bool ExistePeca(Posicao _pos)
        {
            ValidarPosicao(_pos);
            return Peca(_pos) != null;
        }
        public void ColocarPecas(Peca _p, Posicao _pos)
        {
            if (ExistePeca(_pos))
            {
                throw new TabuleiroException("Já Existe uma peça nessa posição");
            }
            Pecas[_pos.linha, _pos.coluna] = _p;
            _p.Posicao = _pos;
        }
        public Peca RetirarPeca(Posicao _pos)
        {
            if (Peca(_pos) == null)
            {
                return null;
            }
            Peca aux = Peca(_pos);
            aux.Posicao = null;
            Pecas[_pos.linha, _pos.coluna] = null;
            return aux;
        }
        public bool PosicaoValida(Posicao _pos)
        {
            if (_pos.linha < 0 || _pos.linha >= Linhas || _pos.coluna < 0 || _pos.coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao _pos)
        {
            if (!PosicaoValida(_pos))
            {
                throw new TabuleiroException("Posição Inválida!!!");
            }
        }
    }
}
