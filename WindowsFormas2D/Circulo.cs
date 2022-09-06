using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormas2D
{
    class Circulo : Forma2D
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public Circulo(double r)
        {
            Radio = r;
        }

        protected override double Area()
        {
            double total = Math.PI * Radio * Radio;
            return total;
        }

        public override string ToString()
        {
            return "Circulo. Radio: " + Radio + ". Area: " + Area() + "." ;
        }
    }
}
