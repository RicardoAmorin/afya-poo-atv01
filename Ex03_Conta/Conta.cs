public class Conta
{
    private readonly int numero;
    private string titular;
    private double saldo;
    private double limite;

    public double SaldoTotal => saldo + limite;
    public string StatusConta => saldo < 0 ? "Negativo" : "Positivo";

    public Conta(int numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        saldo = 0;
        limite = 500;
    }

    public bool Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            return true;
        }
        return false;
    }

    public bool Sacar(double valor)
    {
        if (valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Conta: {numero} | Titular: {titular} | Saldo: {saldo} | Limite: {limite}";
    }
}