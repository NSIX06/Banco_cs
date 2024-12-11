using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco_cs.Models
{
    public abstract class Conta
    {
        #region Atributos
        
            //*Gets e sets
        public Conta(Titular titular, double saldo, DateTime dataAbertura) 
        {
            Titular = titular;
            Saldo = saldo;
            DataAbertura = dataAbertura;

        }
            public Titular Titular {get;set;}
            
            public double Saldo {get; private set;}

            public DateTime DataAbertura{get; private set;}

            //*Variável privada somente para leitura
            private readonly double VALOR_MINIMO = 10.0;

        #endregion

        #region Construtores
            //*Passando os parâmetros
        
            public Conta (Titular titular, double saldoAbertura)
                {
                    Titular = titular;
                    Saldo = saldoAbertura;
                    DataAbertura = DateTime.Now;
                }

                public Conta (Titular titular)
                {
                    Titular = titular;
                    Saldo = 0;
                    DataAbertura = DateTime.Now;
                }

        #endregion

    
    #region Métodos

        //*Função depositar com exeções
        public void Depositar(double valor)
            {
                if (valor < VALOR_MINIMO    )
                    {
                        throw new Exception("Valor minímo para deposito é de R$"+ VALOR_MINIMO);
                    }

                    Saldo = Saldo + valor;
            }

        //*Função sacar com exeções
        public double Sacar(double valor)
            {
                if (valor < VALOR_MINIMO    )
                    {
                        throw new Exception("Valor minímo para saque é de R$"+ VALOR_MINIMO);
                    }
                    else if (valor > Saldo)
                    {
                        throw new Exception("Saldo insuficiente para saque, o seu saldo atual é de R$"+ VALOR_MINIMO);
                    }

                    Saldo = Saldo - valor;

                    return valor;
            }

        //*Função transferir com exeções
        public void Transferir(Conta contaDestino, double valor)
        {
            if (valor < VALOR_MINIMO)
                    throw new Exception($"Valor mínimo para transferência é de R${VALOR_MINIMO}");
            if (valor > Saldo)
                    throw new Exception($"Saldo insuficiente para transferência. Saldo atual: R${Saldo}, Valor solicitado: R${valor}");

                Saldo -= valor; // Subtraia do saldo da conta de origem
                contaDestino.Depositar(valor); // Deposite na conta de destino
        }

        public abstract void ImprimirExtrato();

        #endregion
    }

}