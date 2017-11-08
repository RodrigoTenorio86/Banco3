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
        public string Nome {  get; set; }
        public int idade { get; set; }
        public CPF cpf { get; private set; }


        public Cliente()
        {
            Cliente.Id++;
        }
        public Cliente(string nome)
        {
            this.Nome = nome;
            Cliente.Id++;
        }
        public Cliente(string nome, CPF documento): this(nome)
        {
            this.cpf = documento;
        }

        public override string ToString()
        {
            return this.Nome;
        }

        public override bool Equals(object obj)
        {
            Cliente eu = (Cliente)obj;
            return this.cpf.Equals(eu.cpf);
        }

    }
}
