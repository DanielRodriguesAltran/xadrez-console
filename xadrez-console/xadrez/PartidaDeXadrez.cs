using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class PartidaDeXadrez
    {

        public Tabuleiro tab{get;set;}
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get;private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tab.retirarPeca(origem);
            peca.incrementaMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(peca, destino);
        }   
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Vermelho), new PosicaoXadrez('a',1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Vermelho), new PosicaoXadrez('d',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Vermelho), new PosicaoXadrez('h',1).toPosicao());
           // tab.colocarPeca(new Torre(tab, Cor.Vermelho), new Posicao(0, 7));
           // tab.colocarPeca(new Rei(tab, Cor.Vermelho), new Posicao(2, 4));
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('h', 8).toPosicao());
            //tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(7, 0));

        }


    }
}
