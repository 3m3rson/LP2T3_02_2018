using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{
    class Pessoa
    {
        private Relacionamento namoro;
        private String nome;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        internal Relacionamento Namoro
        {
            get
            {
                return namoro;
            }

            set
            {
                namoro = value;
            }
        }
    }
}
