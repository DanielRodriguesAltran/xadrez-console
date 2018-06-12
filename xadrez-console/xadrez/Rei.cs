using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Rei:Peca
    {
        public Rei(Tabuleiro tab,Cor c) : base(tab, c)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
