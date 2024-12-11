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
            throw new NotImplementedException();
        }
    }
}