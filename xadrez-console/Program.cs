using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Preto), new Posicao(0, 0));
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 7));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
