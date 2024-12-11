// See https://aka.ms/new-console-template for more information
using Banco_cs.bin;
using Banco_cs.Models;

Console.WriteLine("**************");
Console.WriteLine("* Banco em C# *");
Console.WriteLine("**************");

var endereco = new Endereco
{
    CEP = "10000222",
    Rua = "Napoleão",
    Numero = 22,
};

var titular01 = new Titular("Trevor", "12345", "78910", endereco);
var titular02 = new Titular("Michael", "678910", "9101112", endereco);

var conta1 = new ContaPoupanca(titular01, 100.0);
var conta2 = new ContaCorrente(titular02);

Console.WriteLine($"Saldo inicial conta1: {conta1.Saldo}");
Console.WriteLine($"Saldo inicial conta2: {conta2.Saldo}");

try
{
    Console.WriteLine("Tentando transferir R$50,00 da conta1 para conta2...");
    conta1.Transferir(conta2, 50.0);
    Console.WriteLine("Transferência realizada com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine($"Saldo final conta1: {conta1.Saldo}");
Console.WriteLine($"Saldo final conta2: {conta2.Saldo}");
