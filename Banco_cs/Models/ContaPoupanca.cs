using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco_cs.Models
{
    public class ContaPoupanca : Conta //*Classe filha herdando a herança da classe Conta 
    {
        public ContaPoupanca(Titular titular) : base(titular)
        {
        }

        public ContaPoupanca(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }
    }
}