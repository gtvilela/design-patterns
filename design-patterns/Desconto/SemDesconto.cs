﻿using Design_Patterns.Models;

namespace Design_Patterns.Desconto
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }

    }
}
