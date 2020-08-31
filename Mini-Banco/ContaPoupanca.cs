using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    public class ContaPoupanca : Conta , ITributavel
    {
        public ContaPoupanca()
        {
        }
        public void CalculaRendimento()
        {
        }
        public override void Sacar(double valor)
        {   
            if (valor <= 0.0)
            {
                throw new ArgumentException();
            }

            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
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
            return this.Saldo * 0.02;
        }
    }
}
