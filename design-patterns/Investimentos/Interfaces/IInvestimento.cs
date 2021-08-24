using Design_Patterns.Models;

namespace Design_Patterns.Interfaces.Investimentos
{
    public interface IInvestimento
    {
        double Calcula(Conta conta);
    }
}
