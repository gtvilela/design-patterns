using Design_Patterns.Desconto;
using Design_Patterns.Impostos;
using Design_Patterns.Impostos.Interfaces;
using Design_Patterns.Investimentos;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500.0);

            Imposto iccc = new ICCC();
            Console.WriteLine(iccc.Calcula(reforma));

            Imposto icms = new ICMS();
            Console.WriteLine(icms.Calcula(reforma));

            Imposto iss = new ISS();
            Console.WriteLine(iss.Calcula(reforma));

            var conta = new Conta();
            conta.Deposita(200.0, "Gabriela", "5325", DateTime.Now);
            var investimento = new RealizadorDeInvestimentos();
            investimento.Realiza(conta, new Moderado());



            Orcamento orcamento = new Orcamento(400);
            orcamento.AdicionaItem(new Item("CANETA", 200));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            orcamento.AdicionaItem(new Item("TV", 250));
            orcamento.AdicionaItem(new Item("ARMARIO", 250));
            orcamento.AdicionaItem(new Item("MICROONDAS", 250));

            double desconto = new CalculadorDeDescontos().Calcula(orcamento);
            Console.WriteLine(desconto);

            //Decorator
            Imposto iss2 = new ISS(new ICMS(new IKCV()));

            orcamento = new Orcamento(500);

            double valorIss = iss2.Calcula(orcamento);
            Console.WriteLine(valorIss);


            Imposto impostoAlto = new ImpostoMuitoAlto(new ISS());
            double valorImpostoAlto = impostoAlto.Calcula(orcamento);
            Console.WriteLine(valorImpostoAlto);
        }
    }
}
