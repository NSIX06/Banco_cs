namespace Banco_cs.Models
{
    public class ContaInvestimneto : Conta //*Classe filha herdando a herança da classe Conta, podendo criar funções exclusivas na propria classe
    {
        public ContaInvestimneto(Titular titular) : base(titular)
        {
        }

        public ContaInvestimneto(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            
            Console.WriteLine("**************");
            Console.WriteLine("* Extrato Conta Investimento *");
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