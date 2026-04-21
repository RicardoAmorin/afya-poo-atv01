Cofre c = new Cofre("Ricardo", "1234");

Console.WriteLine(c.Abrir("1111"));
Console.WriteLine(c.Abrir("2222"));
Console.WriteLine(c.Abrir("1234"));

Console.WriteLine(c);

Console.WriteLine(c.AlterarSenha("1234", "9999"));

c.Fechar();
Console.WriteLine(c);