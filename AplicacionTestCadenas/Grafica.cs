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
        private int bandera;
        public Grafica()
        {
            InitializeComponent();
            bandera = 0;
        }

        public const int DIAMETRO_ELIPSE = 30;
        public const int ANCHO = 80;
        public const int RADIO = DIAMETRO_ELIPSE / 2;
        public const int MEDIDA_ELIPSE = DIAMETRO_ELIPSE + RADIO;
        public const int TAM_HORIZONTAL = 4000;
        public const int TAM_VERTICAL = 2000;
       
        private Image[] imagenes = new Image[2];
        

        private void btnGraficar_Click(object sender, EventArgs e)
        {
         
            bandera = 1;
           
            lienzo.AutoScroll = true;
            lienzo.AutoScrollMinSize = new Size(TAM_HORIZONTAL, TAM_VERTICAL);

            lienzo.Paint += lienzo_Paint;
            
        }

        private void lienzo_Paint(object sender, PaintEventArgs e)
        {
            if (bandera == 0)
            {
                return;
            }
           
            int mitadAncho = 0;           

            Graphics g;          
            
            g = lienzo.CreateGraphics();          
           
            mitadAncho = TAM_HORIZONTAL / 2;
                        
            g.TranslateTransform(lienzo.AutoScrollPosition.X, lienzo.AutoScrollPosition.Y);
            mostrarArbol(g, mitadAncho, 30, ServicioArbolBinario.getRaiz());
        }

        private void mostrarArbol(Graphics pGrafica, int x, int y, Nodo pNodo)
        {
            Pen pDatos = new Pen(Color.Black);
            Pen pElipse = new Pen(Color.Red);
            Brush b = new SolidBrush(this.ForeColor);
            imagenes[0] = Image.FromFile("imagenes/and.png");
            imagenes[1] = Image.FromFile("imagenes/or.png");
            imagenes[2] = Image.FromFile("imagenes/nand.png");
            imagenes[3] = Image.FromFile("imagenes/nor.png");
            imagenes[4] = Image.FromFile("imagenes/xor.png");
            imagenes[5] = Image.FromFile("imagenes/xnor.png");
            imagenes[6] = Image.FromFile("imagenes/not.png");           

            if (pNodo == null)
            {
               
            }
            else
            {            
                int anchoSeparacion = ServicioArbolBinario.darNiveles(pNodo) * (ANCHO/2);
                String cadena = pNodo.getDatos();
                switch (cadena)
                {

                    case "*":

                        pGrafica.DrawImage(imagenes[0], x - 10, y - 20);                      
                        break;

                    case "+":

                        pGrafica.DrawImage(imagenes[1], x - 10, y - 20);
                        break;

                    case "&":

                        pGrafica.DrawImage(imagenes[2], x - 10, y - 20);
                        break;

                    case "%":

                        pGrafica.DrawImage(imagenes[3], x - 10, y - 20);
                        break;

                    case "#":

                        pGrafica.DrawImage(imagenes[4], x - 10, y - 20);
                        break;

                    case "/":

                        pGrafica.DrawImage(imagenes[5], x - 10, y - 20);
                        break;

                    case "$":

                        pGrafica.DrawImage(imagenes[6], x - 10, y - 20);
                        break;

                    default:

                        pGrafica.DrawEllipse(pDatos, x - 10, y - 20, MEDIDA_ELIPSE, MEDIDA_ELIPSE);
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
