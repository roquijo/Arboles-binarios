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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String devolverCadena()
        {
            String cadena = txtCadena.Text;
            cadena = ServicioArbolBinario.quitarEspacios(cadena);
            if (ServicioArbolBinario.hayParentesisExternos(cadena))
            {
                cadena = ServicioArbolBinario.quitarParentesis(cadena);
            }
            return cadena;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            try
            {
                Nodo raiz = new Nodo(devolverCadena());
                ServicioArbolBinario.setRaiz(raiz);
                ServicioArbolBinario.agregarArbol(raiz);
                MessageBox.Show("Se agrego exitosamente el arbol!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

               // MessageBox.Show("Error al agregar el arbol");
            }
        }

        private void btnEvaluarArbol_Click(object sender, EventArgs e)
        {
           ServicioArbolBinario.calculaResultadoArbol(ServicioArbolBinario.getRaiz());
            String formula = ServicioArbolBinario.quitarParentesis(txtCadena.Text);
            txtResultado.Text = ServicioArbolBinario.getRaiz().getDatos();

        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
           txtPreOrden.Text = ServicioArbolBinario.recorrePreOrden(ServicioArbolBinario.getRaiz(), "");

        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            txtInOrden.Text = ServicioArbolBinario.recorreInOrden(ServicioArbolBinario.getRaiz(),"" );
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            txtPosOrden.Text = ServicioArbolBinario.recorrePosOrden(ServicioArbolBinario.getRaiz(), "");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Text = "";
            txtInOrden.Text = "";
            txtPosOrden.Text = "";
            txtPreOrden.Text = "";
            txtResultado.Text = "";
            txtNumNodos.Text = "";
            txtCadena.Focus();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion desarrollada por: \n" +
                "Juan Pablo Meneses - 2220191009 \n" +
                "Juan Esteban Gomez - 2220191007 \n" +
                "Jorge Eliecer Rojas - 2220191003");
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            
            Grafica graficar = new Grafica();
            graficar.Show();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int num = ServicioArbolBinario.darNodos();

            txtNumNodos.Text = num+"";
        }
    }
}
