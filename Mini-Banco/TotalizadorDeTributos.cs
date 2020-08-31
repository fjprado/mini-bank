using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Banco
{
    class TotalizadorDeTributos
    {
        public double TotalTributos { get; private set; }

        public void Adiciona(Conta[] contas)
        {
            
            foreach (var trib in contas)
            {
                if (trib is ContaCorrente)
                {   
                    TotalTributos += trib.Saldo * 0.05;
                }
                else if (trib is SeguroDeVida)
                {
                    TotalTributos += trib.Saldo * 0.20;
                }
            }
        }
    }
}