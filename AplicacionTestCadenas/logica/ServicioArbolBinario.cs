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
        public static int darNiveles(Nodo pNodo)
        {
            if (pNodo == null)
            {
                return 0;
            }
            else
            {
                if (pNodo.getIzq() != null && pNodo.getDer() != null)
                {
                    return darNiveles(pNodo.getIzq()) + darNiveles(pNodo.getDer()) + 1;
                }
                return darNiveles(pNodo.getIzq()) + darNiveles(pNodo.getDer());
            }
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

           
            if (hayParentesisExternos(cadena))
            {
                    cadena = quitarParentesis(cadena);
            }
               

            if(cadena.Length == posicion)
            {
                separada[0] = null;
                separada[1] = cadena.Substring(0, posicion);
                separada[2] = null;
                return separada;
            }
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
            bool hay;
            if(cadena.Length > 1)
            {
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
            }

            hay = (cuantos == 1) ? true : false;

            return hay;
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

                centinela = (contador == 1) ? true:centinela;

                return centinela;
        }

        public static void agregarArbol(Nodo actual)
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
                
                    int operadorcentral = encontrarOperadorPrincipal(actual.getDatos());
                    String[] cadenas = darCadenaSeparada(actual.getDatos(), operadorcentral);
                    if (cadenas[0] == null || cadenas[1] == null)
                    {
                        return;
                    }
                    Nodo izq = new Nodo(cadenas[0]);
                    actual.setDato(cadenas[1]);
                    Nodo der = new Nodo(cadenas[2]);
                    actual.setIzq(izq);
                    actual.setDer(der);
                    agregarArbol(izq);
                    agregarArbol(der);
            }
        }

        public static double calcularResultado(String[] operacion)
        {
            Double respuesta = 0;
            Double valor1;
            Double valor2;
            valor1 = Convert.ToDouble(operacion[0]);
            valor2 = Convert.ToDouble(operacion[2]);

            switch(operacion[1])
            {
                //Operacion "AND"
                case "*":

                    respuesta = (valor1 == 1 && valor2 == 1)?1:0;

                    break;
                //Operacion "OR"
                case "+":

                    respuesta = (valor1 == 0 && valor2 == 0) ? 0 : 1;

                    break;
               
                //Operacion "NAND"
                case "&":

                    respuesta = (valor1 == 1 && valor2 == 1) ? 0 : 1;
                    
                    break;
                //Operacion "Nor"
                case "%":

                    respuesta = (valor1 == 0 && valor2 == 0) ? 1: 0;
                    
                    break;
                //Operacion "XOR"
                case "#":

                    respuesta = ((valor1 == 0 && valor2 == 0) || (valor1 == 1 && valor2 == 1)) ? 0 : 1;
                   
                    break;

                //Operacion "XNOR"
                case "/":

                    respuesta = ((valor1 == 0 && valor2 == 0) || (valor1 == 1 && valor2 == 1)) ? 1 : 0;
                   
                    break;
                //Operacion "MAT"
                case "$":

                    respuesta = ((valor1 == 0 && valor2 == 0) || (valor1 == 1 && valor2 == 0)) ? 1 : 0;
                    
                    break;                
            }
            return respuesta;
        }

        public static Boolean verificarOperador(String operador)
        {
            if (operador == "*" || operador == "+" || operador == "&" || operador == "%" || operador == "#" || operador == "/" || operador == "$")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void calculaResultadoArbol(Nodo actual)
        {
            if (verificarOperador(actual.getDatos()) && verificarOperador(actual.getIzq().getDatos()))
            {
                calculaResultadoArbol(actual.getIzq());
            }
            if (verificarOperador(actual.getDatos()) && verificarOperador(actual.getDer().getDatos()))
            {
                calculaResultadoArbol(actual.getDer());
            }          
            else
            {           
                    String[] separada;
                    separada = new String[3];
                    separada[0] = actual.getIzq().getDatos();
                    separada[1] = actual.getDatos();
                    separada[2] = actual.getDer().getDatos();
                    actual.setDer(null);
                    actual.setIzq(null);
                    actual.setDato(Convert.ToString(calcularResultado(separada)));
                
            }
            if (actual.getDer() != null && actual.getIzq() != null)
            {
                calculaResultadoArbol(actual);
            }
        }
        public static int darNodos()
        {
            String[] nodos = recorrePreOrden(getRaiz(),"").Split(',');

            return nodos.Length-1;
        }

        public static String recorrePreOrden(Nodo actual, string cad)
        {
            if (actual == null)
            {
                return cad;
            }
            if (esAtomica(actual.getDatos()))
            {
                if (hayParentesisExternos(actual.getDatos()))
                {
                    quitarParentesis(actual.getDatos());
                }
            }          
            cad = cad + actual.getDatos() + ",";
            cad = recorrePreOrden(actual.getIzq(), cad);
            cad = recorrePreOrden(actual.getDer(), cad);

            return cad;
        }
    
        public static String recorreInOrden(Nodo actual, String cad)
        {
            if (actual == null)
            {
                return cad;
            }
            if (esAtomica(actual.getDatos()))
            {
                if (hayParentesisExternos(actual.getDatos()))
                {
                    quitarParentesis(actual.getDatos());
                }
            }

            cad = recorreInOrden(actual.getIzq(), cad);
            cad = cad + actual.getDatos() + ",";
            cad = recorreInOrden(actual.getDer(), cad);

            return cad;
        }
        
        public static String recorrePosOrden(Nodo actual, String cad)
        {
            if (actual == null)
            {
                return cad;
            }
            if (esAtomica(actual.getDatos()))
            {
                if (hayParentesisExternos(actual.getDatos()))
                {
                    quitarParentesis(actual.getDatos());
                }
            }
            cad = recorrePosOrden(actual.getIzq(), cad);
            cad = recorrePosOrden(actual.getDer(), cad);
            cad = cad + actual.getDatos() + ",";

            return cad;
        }
    }
}
