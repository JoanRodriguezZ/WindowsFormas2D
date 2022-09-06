using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormas2D
{
    abstract class Poligono : Forma2D
    {
        public int numLados;
        abstract protected override double Area();
        
        
    }
}
