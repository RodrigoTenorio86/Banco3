using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class TotalizadorDeContas
    {
        public double Total { get; private set; } = 0;

        public double CalcularValor(Conta conta)
        {
            return Total += conta.Saldo;
        }
    }
}
