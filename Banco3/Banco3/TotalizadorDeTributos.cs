using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }
        public void Acumulado(ITributavel t)
        {
            this.Total += t.CalculaTributo();
        }
    }
}
