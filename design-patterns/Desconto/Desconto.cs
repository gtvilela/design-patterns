namespace Design_Patterns.Desconto
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
