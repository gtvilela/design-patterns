using Design_Patterns.Interfaces.Investimentos;
using Design_Patterns.Models;
using System;

namespace Design_Patterns.Investimentos
{
    public class Arrojado : IInvestimento
    {
        private Random Random;

        public Arrojado()
        {
            Random = new Random();
        }
        public double Calcula(Conta conta)
        {
            int chute = Random.Next(10);
            if (chute >= 0 && chute <= 1) return conta.Saldo * 0.5;
            else if (chute >= 2 && chute <= 4) return conta.Saldo * 0.3;
            else return conta.Saldo * 0.006;
        }
    }
}
