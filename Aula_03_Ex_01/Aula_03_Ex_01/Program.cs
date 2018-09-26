using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
           
            p1.Nome = "Dani";
            p1.Identidade = 1234;
            p1.Profissao = "Funcionaria CRA";
            p1.Idade = 20;

            Animal a1 = new Animal();
            a1.Nome = "Bolinha noia";
            a1.Selvagem = true;

            p1.Pet = a1;
            a1.Dono = p1;

            p1.Pet.Brincar();
            a1.Brincar();

            Pessoa p2 = new Pessoa();
            p2.Pet = a1;
            p2.Nome = "Ruubens";

            a1.Dono = p2;

            Console.Read();
          

        }
    }
}
