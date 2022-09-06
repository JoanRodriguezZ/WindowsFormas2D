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

        public Triangulo(double n1, double n2)
        {
            altura1 = n1;
            base1 = n2;
        }

        protected override double Area()
        {
            double total = base1 * altura1 / 2;
            return total;
        }

        public override string ToString()
        {
            return "Triangulo. Altura: " + altura1 + ". Base: " + base1 + ". Area: " + Area() + ".";
        }
    }
}
