using Design_Patterns.Impostos.Interfaces;

namespace Design_Patterns.Impostos
{
    //Template method
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
        public TemplateDeImpostoCondicional() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            if(DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);

    }
}
