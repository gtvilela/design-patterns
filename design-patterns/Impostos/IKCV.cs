using Design_Patterns.Impostos.Interfaces;

namespace Design_Patterns.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
        private bool TemItemMaiorQue100Reais(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}
