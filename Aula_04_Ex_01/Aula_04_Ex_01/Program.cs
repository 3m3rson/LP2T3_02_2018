using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de sobrecarga de métodos
            Figura[] figuras = new Figura[150];
            double areas = 0;

            for(int i = 0;  i < 50; i++)
            {
                figuras[i] = new Circulo(0, 0, i+1);
                figuras[i+50] = new Retangulo(0, 0, i+1,i+1);
                figuras[i+100] = new TrianguloRetangulo(0, 0, i+1, i+1);
            }

            
            foreach (Figura f in figuras)
                areas += f.Area();

           

            Console.WriteLine(areas);

            Console.Read();


        }
    }
}
