using Banco_cs.Models;

namespace Banco_cs.bin
{
    public class ContaCorrente : Conta //*Classe filha herdando a herança da classe Conta
    {
        public ContaCorrente(Titular titular) 
        : base(titular)
        {

        }

        public ContaCorrente(Titular titular, double saldoAbertura) 
        : base(titular, saldoAbertura)
        {
        
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("Imprimindo extrato da conta conrrente!");
        }
    }

}