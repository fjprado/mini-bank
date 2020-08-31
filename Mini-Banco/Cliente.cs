using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente (string nomes)
        {
            this.Nome = nomes;
        }
        public int cpf;
        public int idade;
        public int rg;
    }
}
