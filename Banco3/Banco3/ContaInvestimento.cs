using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

        public override void Deposito(double valor)
        {
            this.Saldo += valor;
        }
    }
}
