namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }
        public Peca()
        {
        }
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QntMovimentos = 0;
        }
        public void IncrementarQntMovimentos()
        {
            QntMovimentos++;
        }
        public abstract bool[,] MovimentosPossiveis();
    }
}
