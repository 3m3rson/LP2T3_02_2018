using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class Retangulo : Figura
    {
        private double largura, comprimento;

        public Retangulo(int x, int y, double largura, double comprimento) : base(x, y)
        {
            Largura = largura;
            Comprimento = comprimento;
        }

        public override double Area()
        {
            return largura * comprimento;
        }


        public override string ToString()
        {
            return base.ToString() + " - Largura: " + Largura + " Comprimento: " + Comprimento ;
        }

        public bool IsQuadrado()
        {
            return largura == comprimento;
        }

        public double Comprimento
        {
            get
            {
                return comprimento;
            }

            set
            {
                comprimento = value;
            }
        }

        public double Largura
        {
            get
            {
                return largura;
            }

            set
            {
                largura = value;
            }
        }
    }
}
