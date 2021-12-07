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
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public void ColocarPecas(Peca _p, Posicao _pos)
        {
            Pecas[_pos.linha, _pos.coluna] = _p;
            _p.Posicao = _pos;
        }
    }
}
