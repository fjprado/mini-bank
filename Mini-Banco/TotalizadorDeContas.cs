using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }

        public void Soma(List<Conta> contas)
        {
            foreach (var c in contas)
            {
                if (c != null)
                    ValorTotal += c.Saldo;
            }
        }
    }
}
