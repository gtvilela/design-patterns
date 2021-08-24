namespace Design_Patterns.Reposta.Interfaces
{
    public interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta OutraResposta { get; set; }
    }
}
