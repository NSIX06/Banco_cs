using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco_cs.Models
{
    public class Titular
    {
        public string Nome {get; set;}

        public string CPF {get; set;}

        public string Telefone {get; set;}

        public Endereco Endereco {get; set;}

        public Titular(string nome, string cpf, string telefone)
        {

            Nome = nome;
            CPF = cpf;
            Telefone = telefone;

        }

         public Titular(string nome, string cpf, string telefone, Endereco endereco)
        {

            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}