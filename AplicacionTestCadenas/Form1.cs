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

            txtResultado.Text = Convert.ToString(Arbol.contarCaracteres(cadena));
        }

        private void btnLocalizarCaracter_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();
            String caracter = txtCaracter.Text.Trim();

            txtResultado.Text = Convert.ToString(Arbol.localizarCaracter(cadena,caracter));
        }

        private void btnQuitarParentesi_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();
            bool tiene = Arbol.hayParentesisExternos(cadena);
            
            if (tiene)
            {
                cadena = Arbol.quitarParentesis(cadena);

                txtCadena.Text = cadena;
            }
        }

        private void btnQuitarEspacios_Click(object sender, EventArgs e)
        {
            String cadena  = txtCadena.Text.Trim();

            txtCadena.Text = Arbol.quitarEspacios(cadena);

        }

        private void btnEncontrarOperadorCentral_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();

            txtResultado.Text = Arbol.encontrarOperadorPrincipal(cadena);
        }

        private void btnAtomica_Click(object sender, EventArgs e)
        {
            String cadena = txtCadena.Text.Trim();

            bool es = Arbol.esAtomica(cadena);

            if (es)
            {
                MessageBox.Show("Es atomica");
            }
            else
            {
                MessageBox.Show("NO es atomica");
            }

        }
    }
}
