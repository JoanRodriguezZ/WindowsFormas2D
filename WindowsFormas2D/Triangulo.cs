using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormas2D
{
    class Triangulo : Poligono
    {
        double altura1;
        double base1;

        public double Altura1 { get => altura1; set => altura1 = value; }
        public double Base1 { get => base1; set => base1 = value; }

        public Triangulo(double n1, double n2)
        {
            Altura1 = n1;
            Base1 = n2;
        }

        protected override double Area()
        {
            double total = Base1 * Altura1 / 2;
            return total;
        }

        public override string ToString()
        {
            return "Triangulo. Altura: " + Altura1 + ". Base: " + Base1 + ". Area: " + Area() + ".";
        }
    }
}
