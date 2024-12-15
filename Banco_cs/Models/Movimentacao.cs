using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco_cs.Enums;

namespace Banco_cs.Models
{
    public class Movimentacao
    {
        private DateTime DataHoraMovimentacao {get; set;}
        private TipoMovimentacao TipoMovimentacao {get; set;}

        private double Valor {get; set;}

        public Movimentacao(TipoMovimentacao tipoMovimentacao, double valor)
        {
            TipoMovimentacao = TipoMovimentacao;
            DataHoraMovimentacao = DateTime.Now;
        }

        public Movimentacao()
        {
        }

        public Movimentacao(TipoMovimentacao tipoMovimentacao)
        {
            TipoMovimentacao = tipoMovimentacao;
        }

        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == TipoMovimentacao.SAQUE ||
            this.TipoMovimentacao == TipoMovimentacao.TRANSFERENCIA)
            ? "-R$" + Valor : "R$" + Valor;


            return $"{DataHoraMovimentacao}hs | {TipoMovimentacao} | {valor}";

            
        }
    }
}