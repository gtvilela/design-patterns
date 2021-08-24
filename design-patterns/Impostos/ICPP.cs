using Design_Patterns.Impostos.Interfaces;

namespace Design_Patterns.Impostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
           return orcamento.Valor >= 500;
           
        } 
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
