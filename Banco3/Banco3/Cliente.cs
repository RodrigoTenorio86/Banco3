using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class Cliente
    {
        public static int Id { get; private set; } = 0;
        public string Nome { get; set; }


        public Cliente()
        {
            Cliente.Id++;
        }
        public Cliente(string nome)
        {
            this.Nome = nome;
            Cliente.Id++;
        }
        
    }
}
