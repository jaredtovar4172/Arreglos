using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosUnidimensionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[20];
        Arreglos x = new Arreglos();
        private void crearYLlenarArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array = x.LlenarArreglo(array);
            MessageBox.Show("El arreglo se lleno de numeros enteros aleatorios", "Arreglos Unidimensionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mostrarContenidoDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            x.MostrarArreglo(array, listBox1);
        }

        private void encontrarLaSumaYElPromedioDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.SumaPromedio(array);
        }

        private void encontrarElNumeroMayorYSuPosicionDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.NumeroMayorYPosicion(array);
        }

        private void encontrarElNumeroMenorYSuPosicionDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.NumeroMenorYPosicion(array);
        }

        private void mostrarLosNumerosParesDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            x.NumerosPares(array,listBox1);
        }

        private void mostrarLosNumerosImparesDelArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            x.NumerosImpares(array,listBox1);
        }
    }
}
