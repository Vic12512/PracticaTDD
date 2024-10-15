using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Cafetera
    {
        private int cantidadDeCafe;

        public Cafetera(int cantidadCafe)
        {
            if (cantidadCafe < 0)
            {
                Console.WriteLine("No se pueden asignar valores negativos.");
            }
            else
            {
                cantidadDeCafe = cantidadCafe;
            }
        }

        public int llenarCafe()
        {
            return cantidadDeCafe;
        }

        public string decirCafe()
        {
            return "Actualmente la cafetera tiene " + cantidadDeCafe + " Oz. de cafe";
        }

        public bool hayCafe(int cantidadCafe)
        {
            if (cantidadDeCafe >= cantidadCafe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void echarCafe(int cantidadCafe)
        {

            if (hayCafe(cantidadCafe))
            {
                cantidadDeCafe -= cantidadCafe;
                Console.WriteLine("Se ha servido " + cantidadCafe + " Oz. de café");
            }
            else
            {
                Console.WriteLine("La cafetera no tiene suficiente cafe... beba agua");
            }

        }
    }
}
