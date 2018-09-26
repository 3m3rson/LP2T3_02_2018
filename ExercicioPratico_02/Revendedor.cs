using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_02
{
    class Revendedor : Funcionario
    {
        public Revendedor(string cpf, string nome, int idade, bool sexo, double valorVendido) : base(cpf, nome, idade, sexo, valorVendido)
        {
        }

        public override double CalculaComissao()
        {
            return ValorVendido * 0.15;
        }
    }
}
