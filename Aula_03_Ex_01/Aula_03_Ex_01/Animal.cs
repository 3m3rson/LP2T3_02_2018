using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Animal
    {
        private String nome, apelido;
        private bool selvagem;
        private Pessoa dono;


        public String Comunicar()
        {
            return Apelido + " está comunicando";
        }

        public void Brincar()
        {
            Console.WriteLine(Nome + " está brincando");
        }

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

        public string Apelido
        {
            get
            {
                return apelido;
            }

            set
            {
                apelido = value;
            }
        }

        public bool Selvagem
        {
            get
            {
                return selvagem;
            }

            set
            {
                selvagem = value;
            }
        }

        internal Pessoa Dono
        {
            get
            {
                return dono;
            }

            set
            {
                dono = value;
            }
        }

        
    }


}
