using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormas2D
{
    class Diagrama
    {
        List<Forma2D> forma2DList;

        public List<Forma2D> Forma2DList { get => forma2DList; set => forma2DList = value; }

        public Diagrama()
        {
             forma2DList = new List<Forma2D>();
        }

        public void AddRectangulo(double l1, double l2)
        {
            Rectangulo r = new Rectangulo(l1, l2);
            forma2DList.Add(r);
        }

        public void AddCirculo(double r)
        {
            Circulo c = new Circulo(r);
            forma2DList.Add(c);
        }

        public void AddTriangulo(double v1, double v2)
        {
            Triangulo t = new Triangulo(v1, v2);
            Forma2DList.Add(t);
        }

        public void AddFormaRandom()
        {
            Random r = new Random();
            int sel = r.Next(3);

            switch (sel)
            {
                case 0:
                    AddRectangulo(5, 7);
                    break;
                case 1:
                    AddCirculo(5);
                    break;
                case 2:
                    AddTriangulo(4, 5);
                    break;
            }

        }
    }
}
