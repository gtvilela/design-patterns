using Design_Patterns.Interfaces.Investimentos;
using Design_Patterns.Models;
using System;

namespace Design_Patterns
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75, "Gabriela", "5325", DateTime.Now);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
