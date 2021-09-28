using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            
            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            //minha função é bool, então deve guardar o retorno em um bool
            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabi = new ContaCorrente();
            contaDaGabi.titular = "Gabi"; 

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabi: " + contaDoBruno.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabi);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabi: " + contaDaGabi.saldo);
            Console.WriteLine(resultadoTransferencia);

            bool resultadoTransferenciaGabi = contaDaGabi.Transferir(100, contaDoBruno);
            Console.WriteLine(resultadoTransferenciaGabi);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaDaGabi.saldo);


            Console.ReadLine();
        }
    }
}
