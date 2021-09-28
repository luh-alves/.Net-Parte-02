using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabi = new ContaCorrente();
            contaGabi.titular = "Gabi";
            contaGabi.agencia = 863;
            contaGabi.numero = 874569;

            ContaCorrente contaGabiCosta = new ContaCorrente();
            contaGabiCosta.titular = "Gabi";
            contaGabiCosta.agencia = 863;
            contaGabiCosta.numero = 874569;

            Console.WriteLine(contaGabi == contaGabiCosta);
            contaGabi = contaGabiCosta;
            Console.WriteLine(contaGabi == contaGabiCosta);

            contaGabiCosta.saldo = 300;
            Console.WriteLine(contaGabi.saldo);

            Console.ReadLine();









        }
    }
}
