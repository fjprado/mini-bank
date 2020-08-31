using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    class ContaInvestimento : Conta , ITributavel
    {

        public override void Sacar(double valor)
        {

            if (valor <= 0.0)
            {
                throw new ArgumentException();
            }

            if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor ;
            }
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.03;
        }
    }
}
