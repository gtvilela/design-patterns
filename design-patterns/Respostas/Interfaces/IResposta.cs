using Design_Patterns.Models;

namespace Design_Patterns.Reposta.Interfaces
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
        IResposta OutraResposta { get; set; }
    }
}
