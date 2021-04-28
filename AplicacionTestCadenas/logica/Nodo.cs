using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTestCadenas.logica
{
    class Nodo
    {

        private String datos;

        private Nodo izq;

        private Nodo der;

        private Nodo raiz;

        public Nodo(String pDato)
        {
            this.datos = pDato;

        }

        public String getDatos()
        {
            return datos;
        }

        public void setDato(String dato)
        {
            this.datos = dato;
        }

        public Nodo getIzq()
        {
            return izq;
        }

        public void setIzq(Nodo izqr)
        {
            this.izq = izqr;
        }

        public Nodo getDer()
        {
            return der;
        }

        public void setDer(Nodo der)
        {
            this.der = der;
        }

        public void setRaiz(Nodo pRaiz)
        {
            raiz = pRaiz;
        }

        public Nodo getRaiz()
        {
            return raiz;
        }
    }
}
