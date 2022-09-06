using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormas2D
{
    public partial class Form1 : Form
    {
        Diagrama dia = new Diagrama();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            dia.AddRectangulo(5, 8);
            ActualizarLista();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            dia.AddTriangulo(5, 8);
            ActualizarLista();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            dia.AddCirculo(8);
            ActualizarLista();
        }

        private void btnFiguraRandom_Click(object sender, EventArgs e)
        {
            dia.AddFormaRandom();
            ActualizarLista();
        }

        private void listBoxFiguras2D_DoubleClick(object sender, EventArgs e)
        {
            listBoxFiguras2D.Items.RemoveAt(listBoxFiguras2D.SelectedIndex);
            ActualizarLista();

        }
        private void listBoxFiguras2D_MouseClick(object sender, MouseEventArgs e)
        {
            dia.Forma2DList.RemoveAt(listBoxFiguras2D.SelectedIndex);
            listBoxFiguras2D.Items.RemoveAt(listBoxFiguras2D.SelectedIndex);
            ActualizarLista();
        }

        void ActualizarLista()
        {
            listBoxFiguras2D.Items.Clear();
            foreach (Forma2D f2d in dia.Forma2DList)
            {
                listBoxFiguras2D.Items.Add(f2d.ToString());
            }
        }

    }
}
