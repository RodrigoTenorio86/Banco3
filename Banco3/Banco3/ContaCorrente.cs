using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class ContaCorrente:Conta
    {

        public ContaCorrente():base() { }
        public ContaCorrente(Cliente titular):base(titular) { }

        public override void Deposito(double valor)
        {
            this.Saldo += valor;
        }

        public override bool Saca(double valor)
        {
            return base.Saca(valor + 0.1);
        }
    }
}
