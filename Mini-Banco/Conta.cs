using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    public abstract class Conta
    {
        private static int numeroDeContas { get; set; }
        public int numero;
        public double Saldo { get; protected set; }
        public Cliente titular;
         public Conta()
        {
            Conta.numeroDeContas++;
            this.numero = Conta.numeroDeContas;

        }
        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }
         public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }
 
        public virtual void Sacar(double valor)
        {
            if (valor >= this.Saldo)
            {
                this.Saldo -= valor;
                
            }
            

        }
    }
}