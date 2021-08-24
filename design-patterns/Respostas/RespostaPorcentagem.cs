using Design_Patterns.Models;
using Design_Patterns.Reposta.Interfaces;
using System;

namespace Design_Patterns.Respostas
{
    public class RespostaPorcentagem : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaPorcentagem(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaPorcentagem()
        {
            OutraResposta = null; // nao recebi a proxima!
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + '%' + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
