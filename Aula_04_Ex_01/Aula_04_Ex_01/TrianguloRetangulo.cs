using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    class TrianguloRetangulo : Figura
    {
        private double baseT, altura;

        public TrianguloRetangulo(int x, int y, double baseT, double altura) : base(x, y)
        {
            BaseT = baseT;
            Altura = altura;
        }

        public string GetTipo()
        {
            return "Trigulo Retangulo";
        }

        public override double Area()
        {
            return baseT * altura / 2;
        }

        public override string ToString()
        {
            return base.ToString() + " - Base: " + BaseT + " Altura: " + Altura;
        }

        public double Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public double BaseT
        {
            get
            {
                return baseT;
            }

            set
            {
                baseT = value;
            }
        }
    }
}
