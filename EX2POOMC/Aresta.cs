using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2POOMC
{
    internal class Aresta
    {
        private double aresta;



        public Aresta(double aresta)

        {

            this.aresta = aresta;

        }



        public double CalcularArea()

        {

            return aresta *aresta;

        }
    }
}
