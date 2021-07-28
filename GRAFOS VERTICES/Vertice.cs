using System;
using System.Collections.Generic;
using System.Text;

namespace GRAFOS_VERTICES
{
    class Vertice
    {
        private int info;
        private Vertice enlaceIzquierdo;
        private Vertice enlaceDerecho;
        private Arco enlaceArco;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }    
        public Vertice EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }

        public Vertice EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }

        public Arco EnlaceArco
        {
            get { return enlaceArco; }
            set { enlaceArco = value; }
        }
    }
}
