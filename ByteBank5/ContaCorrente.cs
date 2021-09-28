using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank5
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;


        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo = saldo - valor;
                return true;
            }
        }

        //quando tem void , não precisa de retorno
        public void Depositar(double valor)
        {
            this.saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo = saldo - valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

