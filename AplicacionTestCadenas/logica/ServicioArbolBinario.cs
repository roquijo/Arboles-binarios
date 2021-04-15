using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTestCadenas.logica
{
    class ServicioArbolBinario
    {

        public static String quitarEspacios(String cadena)
        {
          return  cadena = cadena.Replace(" ", "");
        }

        private static Nodo raiz;


        public static Nodo getRaiz()
        {
            return raiz;
        }
        public static void setRaiz(Nodo pRaiz)
        {
            raiz = pRaiz;
        }

        public static int encontrarOperadorPrincipal(String cadena)
        {
            int cont = 0;
            int pos = 0;
            if (ServicioArbolBinario.hayParentesisExternos(cadena))
            {
                cadena = ServicioArbolBinario.quitarParentesis(cadena);
            }

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
                    return pos = i+1;
                }
            }
            return pos;
        }

        public static String[] darCadenaSeparada(String cadena, int posicion)
        {
            String[] separada;
            separada = new String[3];

            separada[0] = cadena.Substring(0, posicion);
            separada[1] = Convert.ToString(cadena[posicion]);
            separada[2] = cadena.Substring(posicion + 1);

            return separada;
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
                    case '*':
                    case '+':
                    case '&':
                    case '%':
                    case '#':
                    case '/':
                    case '$':
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

        public static void agregarArbol(Nodo actual)
        {
            if (hayParentesisExternos(actual.getDatos()))
            {
                if (esAtomica(actual.getDatos()))
                {

                    int operacionCentro = encontrarOperadorPrincipal(actual.getDatos());
                    String[] cadena = darCadenaSeparada(actual.getDatos(), operacionCentro);
                    Nodo izq = new Nodo(cadena[0]);
                    actual.setDato(cadena[1]);
                    Nodo der = new Nodo(cadena[2]);
                    actual.setIzq(izq);
                    actual.setDer(der);
                }
                else
                {
                    actual.setDato(quitarParentesis(actual.getDatos()));
                    int operadorcentral = encontrarOperadorPrincipal(actual.getDatos());
                    String[] cadenas = darCadenaSeparada(actual.getDatos(), operadorcentral);
                    Nodo izq = new Nodo(cadenas[0]);
                    actual.setDato(cadenas[1]);
                    Nodo der = new Nodo(cadenas[2]);
                    actual.setIzq(izq);
                    actual.setDer(der);
                    agregarArbol(izq);
                    agregarArbol(der);
                }
            }
        }asdasd
            zdasdasdasdasdsadasdasd
        public static double calcularResultado(String[] operacion)
        {
            Double respuesta = 0;
            Double valor1;
            Double valor2;
            valor1 = Convert.ToDouble(operacion[0]);
            valor2 = Convert.ToDouble(operacion[2]);

            if (operacion[1] == "+")
            {
                if (valor1 == 0 && valor2 == 0)
                {
                    respuesta = 0;
                }
                if (valor1 == 0 && valor2 != 0)
                {
                    respuesta = 1;
                }
                if (valor1 != 0 && valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor1 != 0 && valor2 != 0)
                {
                    respuesta = 1;
                }

            }
            else if (operacion[1] == "-")
            {
                if (valor1 == 0 && valor2 == 0)
                {
                    respuesta = 0;
                }
                if (valor1 == 0 && valor2 != 0)
                {
                    respuesta = 1;
                }
                if (valor1 != 0 && valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor1 != 0 && valor2 != 0)
                {
                    respuesta = 0;
                }

            }
            else if (operacion[1] == "*")
            {
                if (valor1 == 0 && valor2 == 0)
                {
                    respuesta = 0;
                }
                if (valor1 == 0 && valor2 != 0)
                {
                    respuesta = 0;
                }
                if (valor1 != 0 && valor2 == 0)
                {
                    respuesta = 0;
                }
                if (valor1 != 0 && valor2 != 0)
                {
                    respuesta = 1;
                }

            }
            else if (operacion[1] == "/")
            {

                if (valor1 == 0 && valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor1 == 0 && valor2 != 0)
                {
                    respuesta = 0;
                }
                if (valor1 != 0 && valor2 == 0)
                {
                    respuesta = 0;
                }
                if (valor1 != 0 && valor2 != 0)
                {
                    respuesta = 0;
                }

            }
            else if (operacion[1] == "^")
            {


                if (valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor2 != 0)
                {
                    respuesta = 0;
                }


            }

            else if (operacion[1] == "%")
            {
                if (valor1 == 0 && valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor1 == 0 && valor2 != 0)
                {
                    respuesta = 1;
                }
                if (valor1 != 0 && valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor1 != 0 && valor2 != 0)
                {
                    respuesta = 0;
                }

            }
            //es un xor negado 
            else if (operacion[1] == "#")
            {
                if (valor1 == 0 && valor2 == 0)
                {
                    respuesta = 1;
                }
                if (valor1 == 0 && valor2 != 0)
                {
                    respuesta = 0;
                }
                if (valor1 != 0 && valor2 == 0)
                {
                    respuesta = 0;
                }
                if (valor1 != 0 && valor2 != 0)
                {
                    respuesta = 1;
                }
            }

            return respuesta;
        }
        public static void calculaResultadoArbol(Nodo actual)
        {
            if (verificarChar(actual.getDatos()) && verificarChar(actual.getIzqr().getDatos()))
            {
                calculaResultadoArbol(actual.getIzqr());
            }
            else
            {

                if (verificarChar(actual.getDerch().getDatos()))
                {
                    calculaResultadoArbol(actual.getDerch());
                }
                else
                {
                    String[] separada;
                    separada = new String[3];
                    separada[0] = actual.getIzqr().getDatos();
                    separada[1] = actual.getDatos();
                    separada[2] = actual.getDerch().getDatos();
                    actual.setDerch(null);
                    actual.setIzqr(null);
                    actual.setDato(Convert.ToString(calcularResultado(separada)));
                }

            }
            if (actual.getDerch() != null && actual.getIzqr() != null)
            {
                calculaResultadoArbol(actual);
            }
        }

    }

    /*
        
        }*/
}
