using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabi = new Cliente();

            //gabi.nome = "Gabi";
            //gabi.profisão = "desenvolvedora #c";
            //gabi.cpf = "123.456.789-87";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabi;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabi";
            conta.titular.cpf = "123.456.789-87";
            conta.titular.profisão = "desenvolvedora #c";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 123456;

            //Console.WriteLine(gabi.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profisão);

            Console.ReadLine();

        }
    }
}
