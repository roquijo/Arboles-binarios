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
            mostrarArbol(grafica, lienzo.Width / 2, 20, ServicioArbolBinario.getRaiz());
        }

        public const int DIAMETRO = 30;
        public const int RADIO = DIAMETRO / 2;
        public const int ANCHO = 50;
       

        private void mostrarArbol(Graphics pGrafica, int x, int y, Nodo pNodo)
        {
            Pen p = new Pen(Color.Black);
            Brush b = new SolidBrush(this.ForeColor);


            if (pNodo == null)
            {

            }
            else
            {
                int anchoSeparacion = Nodo.darNodosCompletos(pNodo) * (ANCHO / 2);

                String cadena = pNodo.getDatos();
                switch (cadena)
                {

                    case "*":
                        
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y - 6);
                        break;
                    case "+":
                       
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y-6);

                        break;
                    case "&":
                       
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y - 6);
                        break;
                    case "%":
                        
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y - 6);
                        break;
                    case "#":
                        
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y - 6);
                        break;
                    case "/":
                        
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y - 6);
                        break;
                    case "$":
                        
                        pGrafica.DrawEllipse(p, x - 10, y - 20, DIAMETRO + RADIO, DIAMETRO + RADIO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 6, y - 6);
                        break;
                    default:
                        pGrafica.DrawEllipse(p, x, y, DIAMETRO, DIAMETRO);
                        pGrafica.DrawString(pNodo.getDatos(), this.Font, b, x + 10, y + 8);
                        break;
                }

                if (pNodo.getIzq() != null)
                {
                    pGrafica.DrawLine(p, x-10, y+2, x - ANCHO - anchoSeparacion + RADIO, y + ANCHO);
                }
                if (pNodo.getDer() != null)
                {
                    pGrafica.DrawLine(p, x + 35, y + 2, x + ANCHO + anchoSeparacion + RADIO, y + ANCHO);
                }
                mostrarArbol(pGrafica, x - ANCHO - anchoSeparacion, y + ANCHO, pNodo.getIzq());
                mostrarArbol(pGrafica, x + ANCHO + anchoSeparacion, y + ANCHO, pNodo.getDer());
            }
        }
    }
}
