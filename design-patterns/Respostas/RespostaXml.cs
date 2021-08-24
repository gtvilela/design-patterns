using Design_Patterns.Reposta.Interfaces;
using System;

namespace Design_Patterns.Reposta
{
    public class RespostaXml : Resposta
    {
        public Resposta OutraResposta { get; set; }
        public RespostaXml(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
