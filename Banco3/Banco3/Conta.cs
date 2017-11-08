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
        public Cliente Titular { get; private set; }

        public Conta()
        {
            Conta.Id++;
        }

        public Conta(Cliente cliente)
        {
            this.Titular = cliente;
            Conta.Id++;
        }

        public virtual bool Saca(double valor)
        {
            var consultar = this.SaldoSuficiente(valor);
            if (consultar)
            {
                this.Saldo -= valor;
            }
            return consultar;
        }

        public virtual void Deposito(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Transfere(double valor,Conta destino)
        {
            var consulta = this.Saca(valor);
            if (consulta)
            {
                destino.Deposito(valor);  // destino.Saldo += valor;
            }
            return consulta;
            
        }
        private bool SaldoSuficiente(double valor)
        {
            if (this.Saldo >= valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    };
}
