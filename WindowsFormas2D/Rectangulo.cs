using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormas2D
{
    class Rectangulo : Poligono
    {
        double lado1;
        double lado2;

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public Rectangulo(double l1, double l2)
        {
            Lado1 = l1;
            Lado2 = l2;
        }

        protected override double Area()
        {
            double total = Lado1 * Lado2;
            return total;
        }

        public override string ToString()
        {
            return "Rectangulo. Lado 1: " + Lado1 + ". Lado 2: " + Lado2 + ". Area: " + Area() + ".";
        }
    }
}
