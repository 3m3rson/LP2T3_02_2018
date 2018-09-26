using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Pessoa
    {
        private string nome, profissao;
        private int idade;
        private long identidade;
        private Animal pet;

        public String Falar()
        {
            return Nome + " está falando."; 
        }

        public void Trabalhar(int horas)
        {
            Console.WriteLine(Nome + " está trabalhando há " + horas + "horas");
        }

        public void Comer()
        {
            Console.WriteLine(Nome + " está comendo coxinha.");
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

        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }

        public long Identidade
        {
            get
            {
                return identidade;
            }

            set
            {
                identidade = value;
            }
        }

        public Animal Pet
        {
            get
            {
                return pet;
            }

            set
            {
                pet = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value >= 0 ? value : 0;
            }
        }
    }
}
