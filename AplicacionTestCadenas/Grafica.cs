using AplicacionTestCadenas.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionTestCadenas
{
    public partial class Grafica : Form
    {
        public Grafica()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            Graphics grafica = lienzo.CreateGraphics();
            mostrarArbol(grafica, lienzo.Width/2, 30, ServicioArbolBinario.getRaiz());
        }

        public const int DIAMETRO = 30;
        public const int ANCHO = 50;
        public const int RADIO = DIAMETRO / 2;
        public const int MEDIDAELIPSE = DIAMETRO + RADIO;

        private void mostrarArbol(Graphics pGrafica, int x, int y, Nodo pNodo)
        {
            Pen pDatos = new Pen(Color.Black);
            Pen pElipse = new Pen(Color.Red);
            Brush b = new SolidBrush(this.ForeColor);

            if (pNodo == null)
            {
               
            }
            else
            {            
                int anchoSeparacion = x / (ServicioArbolBinario.darNodos().Length-1);
                String cadena = pNodo.getDatos();
                switch (cadena)
                {

                    case "*":
                        
                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 3, y - 6);
                        break;

                    case "+":

                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 2, y - 13);
                        break;

                    case "&":

                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 3, y - 10);
                        break;

                    case "%":

                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x , y - 10);
                        break;

                    case "#":

                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 2, y - 10);
                        break;

                    case "/":

                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 5, y - 12);
                        break;

                    case "$":

                        pGrafica.DrawEllipse(pElipse, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 3, y - 12);
                        break;

                    default:

                        pGrafica.DrawEllipse(pDatos, x - 10, y - 20, MEDIDAELIPSE, MEDIDAELIPSE);
                        pGrafica.DrawString(pNodo.getDatos(), new Font("Verdana", 15), b, x + 3, y - 12);
                        break;
                }

                if (pNodo.getIzq() != null)
                {
                    pGrafica.DrawLine(pDatos, x-10, y + 2, x - ANCHO - anchoSeparacion + RADIO, y + ANCHO - RADIO - 5 );
                }
                if (pNodo.getDer() != null)
                {
                    pGrafica.DrawLine(pDatos, x + 35, y + 2, x + ANCHO + anchoSeparacion + RADIO, y + ANCHO - RADIO - 5 );
                }
                mostrarArbol(pGrafica, x - ANCHO - anchoSeparacion, y + ANCHO, pNodo.getIzq());
                mostrarArbol(pGrafica, x + ANCHO + anchoSeparacion, y + ANCHO, pNodo.getDer());
            }
        }
    }
}
