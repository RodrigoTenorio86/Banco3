using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class ContaPoupanca:Conta
    {
        public ContaPoupanca():base()  { }
        public ContaPoupanca(Cliente cliente) :base(cliente)  { }

    }
}
