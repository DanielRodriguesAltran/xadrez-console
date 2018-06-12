﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    class Peca
    {

        public Posicao p { get; set; }
        public Cor c { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao p, Cor c,Tabuleiro tab)
        {
            this.p = p;
            this.c = c;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}