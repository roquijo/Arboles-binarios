using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTestCadenas.logica
{
    class Arbol
    {

        public static String quitarEspacios(String cadena)
        {
          return  cadena = cadena.Replace(" ", "");
        }

        public static String encontrarOperadorPrincipal(String cadena)
        {
            int cont = 0;
            String operador = "";

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '(')
                {
                    cont += 1;
                }
                else if (cadena[i] == ')')
                {
                    cont -= 1;
                }

                if (cont == 0)
                {
                    
                    operador = Convert.ToString(cadena[i + 1]);
                }
            }
            return operador;
        }

        public static String quitarParentesis(String pCadena)
        {
            String resultado = pCadena.Substring(1, pCadena.Length - 2);
            return resultado;
        }

        public static bool hayParentesisExternos(String cadena)
        {
            int cont = 0;
            int cuantos = 0;

            foreach (char c in cadena)
            {
                if (c == '(')
                {
                    cont = cont + 1;
                }
                else if (c == ')')
                {
                    cont = cont - 1;
                }

                if (cont == 0)
                {
                    cuantos++;
                }
            }

            if (cuantos == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int contarCaracteres(String cadena)
        {
            return cadena.Length;
        }

        public static int localizarCaracter(String cadena, String caracter)
        {
            return cadena.IndexOf(caracter);
        }

        public static bool esAtomica(String cadena)
        {
            int contador = 0;
            Boolean centinela = false;
            String cadenaTemp = quitarEspacios(cadena);
            if (hayParentesisExternos(cadena))
            {
                cadenaTemp = quitarParentesis(cadenaTemp);
            }

            foreach (Char caracter in cadenaTemp) {

                switch (caracter)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '^':
                    case '%':
                    case '#':
                        contador++;
                        break;
                }
            }
                if (contador == 1)
                {
                    centinela = true;
                }

                return centinela;
            }
        }
    /*
        private void btnRecorrerContando_Click(object sender, EventArgs e)
        {
            String cadena = "";
            String caracter = "";
            int res = 0;
            int cont = 0;
            int cuantos = 0;

            cadena = txtCadena.Text.Trim();
            caracter = txtCaracter.Text.Trim();

            foreach (char c in cadena)
            {
                if (c == '(')
                {
                    cont = cont + 1;
                }
                else if (c == ')')
                {
                    cont = cont - 1;
                }

                if (cont == 0)
                {
                    cuantos++;
                }
            }

            txtResultado.Text = Convert.ToString(cont);

            if (cuantos == 1)
            {
                MessageBox.Show("Sí hay paréntesis externos!");
            }
            else
            {
                MessageBox.Show("No hay paréntesis externos!");
            }
        }*/
    }
