Conta conta = new Conta(123, "Ricardo");

conta.Depositar(200);
conta.Sacar(600);

Console.WriteLine(conta);
Console.WriteLine("Saldo Total: " + conta.SaldoTotal);
Console.WriteLine("Status: " + conta.StatusConta);