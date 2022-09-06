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

        public Rectangulo(double l1, double l2)
        {
            lado1 = l1;
            lado2 = l2;
        }

        protected override double Area()
        {
            double total = lado1 * lado2;
            return total;
        }

        public override string ToString()
        {
            return "Rectangulo. Lado 1: " + lado1 + ". Lado 2: " + lado2 + ". Area: " + Area() + ".";
        }
    }
}
