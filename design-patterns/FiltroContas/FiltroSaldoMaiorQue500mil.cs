using Design_Patterns.Models;
using System.Collections.Generic;

namespace Design_Patterns.FiltroContas
{
    public class FiltroSaldoMaiorQue500mil : Filtro
    {
        public FiltroSaldoMaiorQue500mil(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroSaldoMaiorQue500mil() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Saldo > 500000)
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
