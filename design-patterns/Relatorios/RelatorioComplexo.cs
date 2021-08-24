using System;
using System.Collections.Generic;

namespace Design_Patterns.Relatorios
{
    public class RelatorioComplexo : TemplateRelatorios
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " - " + c.Titular + " - " + c.Agencia + " - " + c.Saldo);
            }
        }
    }
}
