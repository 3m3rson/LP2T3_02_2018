using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, preco;

            Console.Write("largura: "); // Escreve no console e para o curso na frente
            //Console.ReadLine() retorna uma string, que é convertida pelo Parse para double.
            largura = double.Parse(Console.ReadLine());

            Console.Write("Comprimento: "); 
            comprimento = double.Parse(Console.ReadLine());

            Console.Write("Preço:");
            preco = double.Parse(Console.ReadLine());

            //Escreve o resultado usando concatenação por sobrecarga de operador
            Console.WriteLine("Área: " + (comprimento * largura));
            //Escreve outro resultado, mas colocando posicionadores e atribuindo posteriormente os valores.
            Console.Write("Preço total: {0} reais\n",(comprimento * largura * preco));

            //Espera o usuário digitar algo para encerrar.
            Console.Read();
        }
    }
}
