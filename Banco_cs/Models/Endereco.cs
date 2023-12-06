using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco_cs.Models
{
    public class Endereco
    {
        public string CEP {get; set;}

        public string Rua {get; set;}

        public int Numero {get; set;}

        public string Bairro {get; set;}

        public string UF {get; set;}

        public string Cidade {get; set;}
    }
}