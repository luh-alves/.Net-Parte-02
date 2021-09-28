using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 123456);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabi = new ContaCorrente(867, 123456);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);





            Console.ReadLine();

        }
    }
}
