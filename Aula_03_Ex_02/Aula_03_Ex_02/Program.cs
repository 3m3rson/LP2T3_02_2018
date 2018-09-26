using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa aluno1 = new Pessoa();
            aluno1.Nome = "Maria";

            Pessoa aluno2 = new Pessoa();
            aluno2.Nome = "Paula";

            //Relacionamento r = new Relacionamento(); // Não existe o construtor padrão
            Relacionamento r = new Relacionamento(aluno1, aluno2);

            r.Namorar();
            Console.Read();
        }
    }
}
