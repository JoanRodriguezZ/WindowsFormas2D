using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormas2D
{
    class Circulo : Forma2D
    {
        public double radio;
        public Circulo(double r)
        {
            radio = r;
        }

        protected override double Area()
        {
            double total = Math.PI * radio * radio;
            return total;
        }

        public override string ToString()
        {
            return "Circulo. Radio: " + radio + ". Area: " + Area() + "." ;
        }
    }
}
