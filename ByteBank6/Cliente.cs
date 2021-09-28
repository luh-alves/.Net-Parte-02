using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank6
{
    public class Cliente
    {

        private string _cpf;

        public  string Nome { get; set; }
        public string CPF 
        {
            get
            {
                return _cpf;
            }
            set
            {
                //aqui escrevo minha logica p validação de cpf
                _cpf = value;

            }
        }
        public string Profissao { get; set; }

        


    }
}
