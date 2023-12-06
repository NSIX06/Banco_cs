// See https://aka.ms/new-console-template for more information
using Banco_cs.Models;

Console.WriteLine("**************");
Console.WriteLine("*Banco em C#*");
Console.WriteLine("**************");


//*Criando uma variável titular juntamente com o Endereço  
var titular01 = new Titular("Trevor", "12345", "78910", new Endereco
{
    CEP = "100200300",
    Rua = "Groove",
    Numero = 05
});

//*Criando uma variável conta com o titular e o saldo
var conta1 = new Conta(titular01, 100.0);

System.Console.WriteLine(conta1.Saldo);