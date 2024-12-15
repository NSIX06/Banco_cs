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
            
            Console.WriteLine("**************");
            Console.WriteLine("* Extrato Conta Corrente *");
            Console.WriteLine("**************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " +DateTime.Now);
            Console.WriteLine();

            foreach (var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }
            System.Console.WriteLine("Salado atual: R$" + Saldo);
            Console.WriteLine();
      
            Console.WriteLine("**************");
            Console.WriteLine("* Fim do Extrato*");
            Console.WriteLine("**************");
            Console.WriteLine();
        }
    }

}