using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class Conta
    {
        public static int Id { get; private set; }
        public double Saldo { get; set; }

        public Conta()
        {
            Conta.Id++;
        }
    };
}
