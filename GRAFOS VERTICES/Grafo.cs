using System;
using System.Collections.Generic;
using System.Text;

namespace GRAFOS_VERTICES
{
    class Grafo
    {
        public Vertice grafo;
        Vertice vertice;
        public void insertarVertice(int x)
        {
            Vertice p;
            if (grafo == null)
            {
                grafo = new Vertice();
                grafo.Info = x;
                grafo.EnlaceDerecho = null;
                grafo.EnlaceIzquierdo = null;
                grafo.EnlaceArco = null;
                vertice = grafo;
            }
            else
            {
                p = new Vertice();
                p.Info = x;
                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = vertice;
                p.EnlaceArco = null;
                vertice.EnlaceDerecho = p;
                vertice = p;
            }
        }

        public Vertice buscarVertice(int x)
        {
            Vertice p;
            p = grafo;
            while(p.Info != x || p!=null)
                p = p.EnlaceDerecho;
            return p;
        }

        
        
    }
}
