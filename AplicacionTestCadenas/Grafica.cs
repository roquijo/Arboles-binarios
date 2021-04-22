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

            int ancho = 0, alto = 0, mitadAnchoDer, mitadAlto,anchosIguales,altosIguales,cuantoAncho, cuantoAlto;
            Graphics g;
            Brush b;
            Pen p;

            b = new SolidBrush(this.ForeColor);
            g = lienzo.CreateGraphics();
            p = new Pen(Color.Black, 1);
            ancho = lienzo.Width;
            alto = lienzo.Height;

            mitadAnchoDer = ancho / 2;
            mitadAlto = alto / 2;

            String[] nodos = ServicioArbolBinario.darNodos();

            g.DrawEllipse(p, mitadAnchoDer - 20, 10, 40, 40);
            g.DrawString(nodos[0], this.Font, b, mitadAnchoDer - 5, 20);

            cuantoAncho = ancho / (nodos.Length - 1);
            cuantoAlto = alto / (nodos.Length - 1);

            anchosIguales = cuantoAncho;
            altosIguales = cuantoAlto;

            for (int i = 1; i < nodos.Length-1; i++)
            {

                g.DrawLine(p, anchosIguales , 50, anchosIguales+20, altosIguales);
                g.DrawEllipse(p, anchosIguales-20, altosIguales-20, 40, 40);
                g.DrawString(nodos[i], this.Font, b, anchosIguales - 5, altosIguales - 8);
                anchosIguales += cuantoAncho;

                if(i+1 < nodos.Length - 2)
                {
                    g.DrawEllipse(p, anchosIguales - 20, altosIguales - 20, 40, 40);
                    g.DrawString(nodos[i + 1], this.Font, b, anchosIguales - 5, altosIguales - 8);
                    anchosIguales += cuantoAncho;
                    altosIguales += cuantoAlto;
                }
                
            }
        }

        public static void dibujarRecursivoDer()
        {
            
        }
    }
}
