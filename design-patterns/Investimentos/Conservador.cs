using Design_Patterns.Interfaces.Investimentos;

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
