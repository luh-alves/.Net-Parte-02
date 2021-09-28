using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            ContaCorrente segundaContaCorrente = new ContaCorrente();

         
            primeiraContaCorrente.saldo = 200;
            segundaContaCorrente.saldo = 50;

           
            Console.WriteLine(primeiraContaCorrente.saldo);
            primeiraContaCorrente.saldo += 100;
            Console.WriteLine(primeiraContaCorrente.saldo);

            Console.WriteLine("Primeira conta tem " + primeiraContaCorrente.saldo);
            Console.WriteLine("Segunda conta tem " + segundaContaCorrente.saldo);


            Console.ReadLine();
        }
    }
}
