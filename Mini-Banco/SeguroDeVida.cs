using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    class SeguroDeVida : Conta , ITributavel
    {
        public double CalculaTributos()
        {
            return Saldo = 42;
        }
    }
}
