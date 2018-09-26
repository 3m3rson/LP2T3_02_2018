using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 5;
            string[] palavras = new string[MAX];

            for(int i = 0; i < MAX; i++)
               palavras[i] = Console.ReadLine();

            Console.WriteLine("Palavras que começam com 'a'");
            foreach (string word in palavras)
                if (word[0] == 'a')
                    Console.WriteLine(word);
            

            Console.WriteLine("Frase com palavras terminadas em 'e'");
            foreach (string word in palavras)
                if (word[word.Length - 1] == 'e')
                    Console.Write(word + " ");
            

            string maior, menor;
            maior = menor = palavras[0];

            foreach(string word in palavras)
            {
                if (word.Length > maior.Length)
                    maior = word;
                if (word.Length < menor.Length)
                    menor = word;
            }

            Console.WriteLine("Maior palavra: {0}. Menor palavra {1}", maior, menor);

            Console.WriteLine("Palavras ao contrário:");
            foreach (string word in palavras)
            {
                for (int i = word.Length - 1; i >= 0; i)
                    Console.Write(word[i]);
                Console.Write("\n");
            }

            Console.Read();
        }
    }
}
