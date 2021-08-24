using Design_Patterns.Interfaces.Investimentos;
using Design_Patterns.Models;

namespace Design_Patterns.Investimentos
{
    public class Conservador: IInvestimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
