using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    class ContaCorrente : Conta, ITributavel
    {

        public override void Sacar(double valor)
        {
            if (valor <= 0.0)
            {
                throw new ArgumentException();

            }
            if ((valor + 0.15) > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                base.Saldo -= (valor + 0.15);
            }
            
        }
        public override void Depositar(double valor)
        {
            if (valor <= 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                base.Saldo += valor;
            }
            
        }
        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }

       
    }
}
