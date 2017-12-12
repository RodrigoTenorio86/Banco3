using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    abstract class Conta
    {
        public static int Id {  get; private set; }
        public double Saldo { get;protected set; }
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

        public abstract void Deposito(double valor);
        
        public virtual bool Transfere(double valor,Conta destino)
        {
            var consulta = this.Saca(valor);
            if (consulta)
            {
                destino.Deposito(valor);  // destino.Saldo += valor;
            }
            return consulta;
            
        }

        public static int getNumeroConta()
        {
            return Conta.Id;
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

        public override bool Equals(object obj)
        {
            if(!(obj is Conta))
            {
                  return false;
            }
            Conta c = (Conta)obj;
            return this.Titular.Equals(c.Titular);
        }
    };
}
