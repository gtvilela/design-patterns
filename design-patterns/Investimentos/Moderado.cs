using Design_Patterns.Interfaces.Investimentos;
using Design_Patterns.Models;
using System;

namespace Design_Patterns.Investimentos
{
    public class Moderado : IInvestimento
    {
        private Random Random;
        public Moderado()
        {
            Random = new Random();
        }
        public double Calcula(Conta conta)
        {
            if (Random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}
