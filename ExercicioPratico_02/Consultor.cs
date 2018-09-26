using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_02
{
    class Consultor : Funcionario
    {

        private List<Funcionario> funcionarios = new List<Funcionario>();

        public Consultor(string cpf, string nome, int idade, bool sexo, double valorVendido) : base(cpf, nome, idade, sexo, valorVendido)
        {
        }

        public override double CalculaComissao()
        {
            double comissao = ValorVendido * 0.15;
            foreach (Funcionario f in funcionarios)
                comissao += f.CalculaComissao() * 0.3;
            return comissao;
        }

        public void AddFuncionario(Funcionario f)
        {
            funcionarios.Add(f);
        }

        public int NumSubordinados()
        {
            return funcionarios.Count;
        }
    }
}
