using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{
    class Relacionamento
    {

        private Pessoa pessoa1, pessoa2;

        public Relacionamento (Pessoa p1, Pessoa p2)
        {
            Pessoa1 = p1;
            Pessoa2 = p2;
        }
        public void Namorar()
        {
            Console.WriteLine(Pessoa1.Nome + " e " + Pessoa2.Nome + " 9estão namorando");
        }

        public Pessoa Pessoa1
        {
            get
            {
                return pessoa1;
            }

            set
            {
                pessoa1 = value;
            }
        }

        public Pessoa Pessoa2
        {
            get
            {
                return pessoa2;
            }

            set
            {
                pessoa2 = value;
            }
        }
    }
}
