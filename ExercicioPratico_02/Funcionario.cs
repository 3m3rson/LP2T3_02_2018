using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_02
{
    abstract class Funcionario
    {
        private string cpf, nome;
        private int idade;
        private bool sexo;
        private double valorVendido;

        public Funcionario(string cpf, string nome, int idade, bool sexo, double valorVendido)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.ValorVendido = valorVendido;
        }

        public abstract double CalculaComissao();

        public override string ToString()
        {
            return "[" + Cpf + ", " + Nome + ", " + idade + ", " + (Sexo? "F":"M")  + ", " + ValorVendido + "]";
        }
        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
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
                idade = value;
            }
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

        public bool Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public double ValorVendido
        {
            get
            {
                return valorVendido;
            }

            set
            {
                valorVendido = value;
            }
        }
    }
}
