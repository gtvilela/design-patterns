using Design_Patterns.Impostos.Interfaces;

namespace Design_Patterns.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
