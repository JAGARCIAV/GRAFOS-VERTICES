using System;
using System.Collections.Generic;
using System.Text;

namespace GRAFOS_VERTICES
{
    class Arco
    {
        private Arco enlaceArco;
        private Vertice enlaceVertice;

        public Vertice EnlaceVertice
        {
            get { return enlaceVertice; }
            set { enlaceVertice = value; }
        }

        public Arco EnlaceArco
        {
            get { return enlaceArco; }
            set { enlaceArco = value; }
        }
    }
}
