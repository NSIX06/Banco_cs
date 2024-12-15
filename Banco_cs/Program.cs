// See https://aka.ms/new-console-template for more information
using Banco_cs.bin;
using Banco_cs.Enums;
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

var conta1 = new ContaCorrente(titular01, 100.0); // Conta com cheque especial de R$200
var conta2 = new ContaInvestimneto(titular02, 50.0);

try
{
    Console.WriteLine("Tentando sacar R$250 da conta1...");
    conta1.Sacar(250.0); // Usa o cheque especial
    Console.WriteLine("Saque realizado com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

conta1.ImprimirExtrato();
conta2.ImprimirExtrato();

// var conta1 = new ContaCorrente(titular01, 100.0);
// var conta2 = new ContaInvestimneto(titular02);
// var conta3 = new ContaPoupanca(titular02);

// conta1.Depositar(50.0);

// conta2.Depositar(500.0);
// conta2.Sacar(100.00);
// conta2.Transferir(conta3, 100.0);

// conta3.Sacar(25.0);

// conta1.ImprimirExtrato();
// conta2.ImprimirExtrato();
// conta3.ImprimirExtrato();

Console.WriteLine();
