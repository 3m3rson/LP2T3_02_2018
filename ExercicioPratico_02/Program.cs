using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_02
{

    //Tempo gasto no desenvolvimento completo: 25 minutos.
    class Program
    {
        static void Main(string[] args)
        {
            //Cria o discionário do tipo da superclasse
            Dictionary<string, Funcionario> f = new Dictionary<string, Funcionario>();

            //Cria as subclasses com os dados para teste
            Consultor huffman = new Consultor("12312312312", "David A. Huffman", 74, false, 7000);
            Consultor ada = new Consultor("32132132131", "Augusta Ada Byron", 36, true, 3000);
            Consultor dijkstra = new Consultor("21321321313", "Edsger Dijkstra", 72, false, 1520);
            Consultor turing = new Consultor("45645645646", "Alan Mathison Turing", 41, false, 780);

            Revendedor neumann = new Revendedor("65465465464", "John von Neumann", 53, false, 300);
            Revendedor knuth = new Revendedor("90219021902", "Donald Ervin Knuth", 80, false, 432);
            Revendedor hopper = new Revendedor("54654654654", "Grace Murray Hopper", 85, true, 432);

            //Associa os funcionários sobordinados aos consultores 
            huffman.AddFuncionario(ada);
            huffman.AddFuncionario(dijkstra);

            ada.AddFuncionario(turing);

            turing.AddFuncionario(neumann);
            turing.AddFuncionario(knuth);

            dijkstra.AddFuncionario(hopper);

            //Adiciona todo mundo no dicionário 
            f.Add(huffman.Cpf, huffman);
            f.Add(ada.Cpf, ada);
            f.Add(dijkstra.Cpf, dijkstra);
            f.Add(turing.Cpf, turing);
            f.Add(neumann.Cpf, neumann);
            f.Add(knuth.Cpf, knuth);
            f.Add(hopper.Cpf, hopper);

            //Itera o dicionário 
            foreach(Funcionario x in f.Values)
            {
                //Imprime o 'estado | comissao' de cada funcionário usando polimorfismo
                Console.WriteLine(x + " | Comissao: " + x.CalculaComissao());
                //verifica se x é do tipo consultor
                if (x is Consultor)
                    //se for, trata o Funcionário 'x' como consultor usando cast (Consultor)
                    //dessa forma, há como ter acesso ao método NumSubordinados em x
                    Console.WriteLine("Num. Subordinados: " + ((Consultor)x).NumSubordinados());
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
