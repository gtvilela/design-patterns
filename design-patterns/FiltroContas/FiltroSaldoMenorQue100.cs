using System.Collections.Generic;

namespace Design_Patterns.FiltroContas
{
    public class FiltroSaldoMenorQue100 : Filtro
    {
        public FiltroSaldoMenorQue100(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroSaldoMenorQue100() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Saldo < 100)
                {
                    filtrada.Add(c);
                }
            }

            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
