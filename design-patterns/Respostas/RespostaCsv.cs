using Design_Patterns.Models;
using Design_Patterns.Reposta.Interfaces;
using System;

namespace Design_Patterns.Respostas
{
    public class RespostaCsv : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaCsv(IResposta outraResposta)
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
