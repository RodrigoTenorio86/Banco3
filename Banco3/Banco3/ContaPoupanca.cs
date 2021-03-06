﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class ContaPoupanca:Conta,ITributavel
    {
        public ContaPoupanca():base()  { }
        public ContaPoupanca(Cliente cliente) :base(cliente)  { }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

        public override void Deposito(double valor)
        {
            this.Saldo += valor;
        }

    }
}
