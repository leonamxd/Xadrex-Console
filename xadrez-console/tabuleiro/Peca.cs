namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }
        public Peca()
        {
        }
        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QntMovimentos = 0;
        }
    }
}
