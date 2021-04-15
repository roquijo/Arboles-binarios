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

        private void btnContarCarateres_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();

            txtResultado.Text = Convert.ToString(ServicioArbolBinario.contarCaracteres(cadena));
        }

        private void btnLocalizarCaracter_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();
            String caracter = txtCaracter.Text.Trim();

            txtResultado.Text = Convert.ToString(ServicioArbolBinario.localizarCaracter(cadena,caracter));
        }

        private void btnQuitarParentesi_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();
            bool tiene = ServicioArbolBinario.hayParentesisExternos(cadena);
            
            if (tiene)
            {
                cadena = ServicioArbolBinario.quitarParentesis(cadena);

                txtCadena.Text = cadena;
            }
        }

        private void btnQuitarEspacios_Click(object sender, EventArgs e)
        {
            String cadena  = txtCadena.Text.Trim();

            txtCadena.Text = ServicioArbolBinario.quitarEspacios(cadena);

        }

        private void btnEncontrarOperadorCentral_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();

            cadena = ServicioArbolBinario.quitarEspacios(cadena);

            txtResultado.Text = Convert.ToString(ServicioArbolBinario.encontrarOperadorPrincipal(cadena));
        }

        private void btnAtomica_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();

            bool es = ServicioArbolBinario.esAtomica(cadena);

            if (es)
            {
                MessageBox.Show("Es atomica");
            }
            else
            {
                MessageBox.Show("NO es atomica");
            }

        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            try
            {
                String cadena = txtCadena.Text;
                cadena = ServicioArbolBinario.quitarEspacios(cadena);
                if (ServicioArbolBinario.hayParentesisExternos(cadena))
                {
                    cadena = ServicioArbolBinario.quitarParentesis(cadena);
                }
                Nodo raiz = new Nodo(cadena);
                ServicioArbolBinario.setRaiz(raiz);
                ServicioArbolBinario.agregarArbol(raiz);
                MessageBox.Show("Se agrego exitosamente el arbol!", "Aviso");
            }
            catch (Exception)
            {
                MessageBox.Show("F");
            }
        }
    }
}
