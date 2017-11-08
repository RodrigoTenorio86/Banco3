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
        public double Saldo { get;private set; }

        public Conta()
        {
            Conta.Id++;
        }

        public bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transfere(double valor,Conta destino)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                destino.Deposito(valor);  // destino.Saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    };
}
