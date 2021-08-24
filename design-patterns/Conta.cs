using System;

namespace Design_Patterns
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public void Deposita(double valor, string titular, string agencia, DateTime dataAbertura)
        {
            Saldo += valor;
            Titular = titular;
            Agencia = agencia;
            DataAbertura = dataAbertura;
        }
    }
}
