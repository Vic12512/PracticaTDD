using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Azucarero
    {
        private static Azucarero instaciaUnica;
        private int cantidadDeAzucar;

        private Azucarero(int cantidadInicial) {
            if (cantidadInicial < 0) {
                throw new ArgumentException("La cantidad de azúcar no puede ser negativa.");
            }
            cantidadDeAzucar = cantidadInicial;
        }

        public static Azucarero ObtenerInstancia(int cantidadInicial = 0)
        {
            if (instaciaUnica == null)
            {
                instaciaUnica = new Azucarero(cantidadInicial);
            }
            return instaciaUnica; 
        }

        public void setAzucar(int cantidad){
            if (cantidad < 0)
            {
                throw new ArgumentException("La cantidad de azúcar no puede ser negativa.");
            }
            cantidadDeAzucar += cantidad;
        }

        public string getAzucar(){
            return "Actualmente el azucarero cuenta con: " + cantidadDeAzucar + " cucharadas";
        }

        public bool hasAzucar(int cantidad) { return cantidadDeAzucar >= cantidad; }

        public void giveAzucar(int cantidad){
        
            if( hasAzucar(cantidad)){
               cantidadDeAzucar -= cantidad;
            }
            else{
                throw new InvalidOperationException("El azucarero no tiene suficiente azúcar... Pidele azucar a la vecina");
            }
        }
    }
}
