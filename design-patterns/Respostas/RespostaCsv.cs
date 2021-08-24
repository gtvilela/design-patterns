using Design_Patterns.Reposta.Interfaces;
using System;

namespace Design_Patterns.Respostas
{
    public class RespostaCsv : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaCsv(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
