using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Deposito(1000);
            System.Console.WriteLine(conta.Saca(200));
            System.Console.Read();
        }
    }
}
