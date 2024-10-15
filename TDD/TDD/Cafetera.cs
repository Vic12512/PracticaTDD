using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Cafetera
    {
        private static Cafetera instanciaUnica;
        private int cantidadDeCafe;

        private Cafetera(int cantidadInicial)
        {
            if (cantidadInicial < 0)
            {
               throw new ArgumentException("La cantidad de café no puede ser negativa.");
            }
               cantidadDeCafe = cantidadInicial;
        }

        public static Cafetera ObtenerInstancia(int cantidad = 0)
        {
            if(instanciaUnica == null)
            {
                instanciaUnica = new Cafetera(cantidad);
            }
            return instanciaUnica;
        }

        public void setCafe(int cantidad)
        {
           if (cantidad < 0)
            {
                throw new ArgumentException("La cantidad de café no puede ser negativa.");
            }
           cantidadDeCafe += cantidad;
        }

        public string getCafe()
        {
            return "Actualmente la cafetera tiene " + cantidadDeCafe + " Oz. de café.";
        }

        public bool hasCafe(int cantidad) { return cantidadDeCafe >= cantidad; }

        public void giveCafe(int cantidad)
        {

            if (hasCafe(cantidad))
            {
                cantidadDeCafe -= cantidad;
            }
            else
            {
                throw new InvalidOperationException("La cafetera no tiene suficiente café... beba agua.");
            }          
        }
    }
}
