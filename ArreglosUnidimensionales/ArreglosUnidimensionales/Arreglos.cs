using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosUnidimensionales
{
    class Arreglos
    {
        public int[] LlenarArreglo(int[] A)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                A[i] = rnd.Next(500);
            }
            return (A);
        }
        public void MostrarArreglo(int[] A, ListBox caja)
        {
            for (int i = 0; i < 20; i++)
            {
                caja.Items.Add("A[" + i + "]= " + A[i]);
            }
        }
        public void SumaPromedio(int[] A)
        {
            double prom = 0;
            int suma = 0;
            for (int i = 0; i < 20; i++)
            {
                suma = suma + A[i];
            }
            prom = suma / 20;
            MessageBox.Show("La suma de los numeros del arreglo es:" + suma + "\n" + "El promedio de los numeros del arreglo es: " + prom, "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void NumeroMayorYPosicion(int[] A)
        {
            int max, pos = 0;
            max = A[0];
            for (int i = 0; i < 20; i++)
            {
                if (max < A[i])
                {
                    max = A[i];
                    pos = i;
                }
            }
            MessageBox.Show("El valor máximo del array es: " + max + " Su posicion es " + pos);
        }
        public void NumeroMenorYPosicion(int[] A)
        {
            int min, pos = 0;
            min = A[0];
            for (int i = 0; i < 20; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                    pos = i;
                }
            }
            MessageBox.Show("El valor minimo del array es: " + min + " Su posicion es " + pos);
        }
        public void NumerosPares(int[] A,ListBox caja)
        {
            int numero = A[0];
            for (int i = 0; i < 20; i++)
            {
                if (A[i] % 2 == 0)
                {
                    caja.Items.Add("A[" + i + "]= " + A[i]);
                }
            }
        }
        public void NumerosImpares(int[] A, ListBox caja)
        {
            int numero = A[0];
            for (int i = 0; i < 20; i++)
            {
                if (A[i] % 2 != 0)
                {
                    caja.Items.Add("A[" + i + "]= " + A[i]);
                }           
            }
        }
    }
}


