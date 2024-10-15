using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Vasos
    {
        private int cantidadDeVasos;
        private int contenido;

        public Vasos(int cantidadVasos, int capacidad)
        {
            if (cantidadVasos < 0 || capacidad < 0)
            {
                Console.WriteLine("No se pueden asignar valores negativos.");
            }
            else
            {
                cantidadDeVasos = cantidadVasos;
                contenido = capacidad;
            }
        }

        public int llenarVasos()
        {
            return cantidadDeVasos;
        }

        public string decirVasos()
        {
            return "Actualmente tienemos " + cantidadDeVasos + " vasos disponibles";
        }

        public bool hayVasos(int cantidadVasos)
        {
            if (cantidadDeVasos >= cantidadVasos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void usarVasos(int cantidadVasos)
        {

            if (hayVasos(cantidadVasos))
            {
                cantidadDeVasos -= cantidadVasos;
                for (int i = 0; i > cantidadVasos; i++)
                {
                    Console.WriteLine("Se ha servido su vaso de café #" + i);
                }
            }
            else
            {
                Console.WriteLine("No hay suficientes vasos, ve a buscar");
            }

        }
    }
}
